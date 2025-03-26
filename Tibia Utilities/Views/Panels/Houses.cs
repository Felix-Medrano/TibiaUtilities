using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tibia_Utilities.Controllers.Houses;
using Tibia_Utilities.Core;
using Tibia_Utilities.CustomControls;
using Tibia_Utilities.CustomControls.Houses;
using Tibia_Utilities.Interfaces.Panels;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models;
using Tibia_Utilities.Models.Houses;

namespace Tibia_Utilities.Views.Panels
{
  public partial class Houses : Form, IViewPanel
  {

    private WorldController _worldController = new();
    private HouseController _houseController = new();

    private ObjectPool<CustomControls.Houses.HousesList> housesListPool;
    private List<CustomControls.Houses.HousesList> gettedHousesList = new();

    private ConcurrentDictionary<int, House> _houseByIdCache = new ();
    private ConcurrentDictionary<string, Models.Houses.Houses> _housesByWorldCache = new();

    private CustomControls.Houses.HousesList currentHousesList = new();

    private HouseDataView currentHouseDataView = new();

    private string currentWorld = string.Empty;
    private string backgroundImageBase64;

    /// <summary>
    /// Constructor de la clase.
    /// </summary>
    public Houses()
    {
      InitializeComponent();

      var countTowns = typeof(TUStrings.Towns).GetFields().Length;

      housesListPool = new ObjectPool<CustomControls.Houses.HousesList>(countTowns);
#if DEBUG
      // inicializamos pocos objetos para un arranque mas rapido
      Helper.HouseDataViewPool = new ObjectPool<CustomControls.Houses.HouseDataView>(10).InitializePool();
#else
      // inicializamos los objetos necesarios mejor rendimiento, pero mas lento al arrancar
      Helper.HouseDataViewPool = new ObjectPool<CustomControls.Houses.HouseDataView>(135).InitializePool();
#endif
      Helper.HouseDataViewPool.ToString().ConsoleWL();

      housesContainer.AutoSize = true;
      housesContainer.Height = 0;

      InitLbls();

      _ = GetWorlds();

      #region TownsComboBox
      int townIndex = 0;
      List<DropDownDataModel> townsDropDownData = new ();

      townsDropDownData.Add(new DropDownDataModel()
      {
        index = townIndex++,
        text = TUStrings.ALL_TOWNS,
      });
      foreach (var item in typeof(TUStrings.Towns).GetFields())
      {
        var value = item.GetValue(null).ToString();
        townsDropDownData.Add(new DropDownDataModel()
        {
          index = townIndex++,
          text = value,
        });
      }
      townsComboBox.SetText(TUStrings.ALL_TOWNS);
      townsComboBox.SetData(townsDropDownData);

      townsComboBox.DropDownPanel.LabelClick += DropDownPanel_LabelClick;

      #endregion

      #region HousesTypeComboBox

      int houseTypeIndex = 0;
      List<DropDownDataModel> housesDropDownData = new ();

      foreach (var item in typeof(TUStrings.HouseType).GetFields())
      {
        var value = item.GetValue(null).ToString();
        housesDropDownData.Add(new DropDownDataModel()
        {
          index = houseTypeIndex++,
          text = value,
        });
      }
      housesTypeComboBox.SetText(TUStrings.HouseType.ALL_HOUSES);
      housesTypeComboBox.SetData(housesDropDownData);

      housesTypeComboBox.DropDownPanel.LabelClick += DropDownPanel_LabelClick;

      #endregion

      #region HouseStateComboBox


      int houseStateIndex = 0;
      List<DropDownDataModel> housesStateDropDownData = new ();

      foreach (var item in typeof(TUStrings.HouseState).GetFields())
      {
        var value = item.GetValue(null).ToString();
        housesStateDropDownData.Add(new DropDownDataModel()
        {
          index = houseStateIndex++,
          text = value,
        });
      }
      houseStateComboBox.SetText(TUStrings.HouseState.ALL_STATE);
      houseStateComboBox.SetData(housesStateDropDownData);
      houseStateComboBox.DropDownPanel.LabelClick += DropDownPanel_LabelClick;

      #endregion

      rightScrollBar.UpdateThumbHeight();
      worldsComboBox.DropDownPanel.LabelClick += DropDownPanel_LabelClick;

      backgroundImageBase64 = Helper.ImageToBase64(Properties.Resources.TextureBackground, ImageFormat.Png);

      SetMapHouseView();
    }

    /// <summary>
    /// Evento de click en la vista de la casa.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public async void OnHouseDataViewClick(object sender, HouseDataView e)
    {
      if (currentHouseDataView == e) return;

      if (currentHouseDataView == null) // Si no hay lista mostrada, se asigna y se muestra la seleccionada
      {
        currentHouseDataView = e;
        currentHouseDataView.DataSelected(true);
      }
      else if (currentHouseDataView != e) // De haber lista mostrada y ser diferente a la seleccionada, se actualiza
      {
        currentHouseDataView.DataSelected(false);
        currentHouseDataView = null;
        currentHouseDataView = e;
        currentHouseDataView.DataSelected(true);
      }
      else // Al ser la misma lista, se cierra
      {
        currentHouseDataView.DataSelected(false);
        currentHouseDataView = null;
      }
      SetLeftVisibilityLbls(false);

      leftStateLbl.Visible = true;
      leftStateLbl.Text = TUStrings.LOADING;
      housesContainer.Enabled = false;

      var house = await _houseController.GetHouseById(worldsComboBox.GetText(), e.GetData().house_id);

      housesContainer.Enabled = true;

      SetMapHouseView(house.img);
      lblBeds.Visible =
      lblBedsCant.Visible = true;

      lblBedsCant.Text = house.beds.ToString();

      if (house.status.is_auctioned)
      {
        leftStateLbl.Text = TUStrings.LeftDataString.AUCTION;

        if (house.status.auction.current_bid == 0)
        {
          noBidInfo.Visible = true;
          return;
        }

        coinImg.Visible =
        infoA.Visible =
        infoB.Visible =
        infoC.Visible = true;

        leftTitleA.Text = TUStrings.LeftDataString.HIGHEST_BIDDER;
        leftDescA.Text = house.status.auction.current_bidder;

        string localEndTime = Helper.ConvertUTCToLocalTime(house.status.auction.auction_end);
        leftTitleB.Text = TUStrings.LeftDataString.END_TIME;
        leftDescB.Text = localEndTime;

        leftTitleC.Text = TUStrings.LeftDataString.HIGHEST_BID;
        leftDescC.Text = house.status.auction.current_bid.ToString("N0");

        return;
      }

      if (house.status.is_rented)
      {
        infoA.Visible =
        infoB.Visible = true;

        leftStateLbl.Text = TUStrings.LeftDataString.RENTAL_DETAILS;

        leftTitleA.Text = TUStrings.LeftDataString.TENANT;
        leftDescA.Text = house.status.rental.owner;

        string localPaidUntil = Helper.ConvertCESTToLocalTime(house.status.rental.paid_until);
        leftTitleB.Text = TUStrings.LeftDataString.PAID_UNTIL;
        leftDescB.Text = localPaidUntil;
        return;
      }

      if (house.status.is_moving)
      {
        "Casa en movimiento".ConsoleWL();
        return;
      }

      if (house.status.is_transfering)
      {
        "Casa en transferencia".ConsoleWL();
        return;
      }
    }

    /// <summary>
    /// Evento de scroll en el panel de casas.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);

      rightScrollBar.MoveThumbByWheel(e.Delta);
    }

    /// <summary>
    /// Evento de click en el panel de casas.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public async void HouseListTopBar_Click(object sender, CustomControls.Houses.HousesList e)
    {
      var selectedHouseList = sender as CustomControls.Houses.HousesList;
      if (currentHousesList == null) //Si no hay lista mostrada, se asigna y se muestra la seleccionada
      {
        await selectedHouseList.ShowHouseDataView();
        currentHousesList = selectedHouseList;
      }
      else if (currentHousesList != selectedHouseList) // de haber lista mostrada y ser diferente a la seleccioanda, se actualiza
      {
        await currentHousesList.DisposeHouseDataView();
        currentHousesList = null;
        currentHousesList = sender as CustomControls.Houses.HousesList;
        currentHouseDataView = null;

        await selectedHouseList.ShowHouseDataView();
      }
      else if (selectedHouseList.Minimized) // al ser la misma lista, se cierra
      {
        await currentHousesList.DisposeHouseDataView();
        currentHousesList = null;
        currentHouseDataView = null;
      }
      SetMapHouseView();
      SetLeftVisibilityLbls(false);
      RelocateHousesLists();
      rightScrollBar.UpdateThumbHeight();
    }

    /// <summary>
    /// Evento de scroll en el panel de casas.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MouseWheelEvent(object sender, MouseEventArgs e)
    {
      OnMouseWheel(e);
    }

    /// <summary>
    /// Evento de click en el label del dropdown.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="data"></param>
    private void DropDownPanel_LabelClick(object sender, DropDownDataModel data)
    {
      var lbl = sender as TULabel;

      lbl.TibiaComboBox.SetText(data.text);
      lbl.TibiaComboBox.HideDropDown();
    }

    /// <summary>
    /// Establece la visibilidad de los labels de la izquierda.
    /// </summary>
    /// <param name="state">Estado de los labels.</param>
    private void SetLeftVisibilityLbls(bool state)
    {
      coinImg.Visible =
      lblBeds.Visible =
      lblBedsCant.Visible =
      leftStateLbl.Visible =
      noBidInfo.Visible =
      infoA.Visible =
      infoB.Visible =
      infoC.Visible = state;
    }

    /// <summary>
    /// Inicializa los labels.
    /// </summary>
    private void InitLbls()
    {
      rightLblNoInfo.Font = Helper.safeFont12;
      rightLblNoInfo.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
      rightLblNoInfo.Text = TUStrings.HOUSES_NO_INFO;
      rightLblNoInfo.CenterControlToParent();

      leftStateLbl.Font = leftTitleA.Font = leftTitleB.Font =
      leftTitleC.Font = leftDescA.Font = leftDescB.Font =
      leftDescC.Font = noBidInfo.Font = Helper.safeFont9;

      lblBeds.Font =
      lblBedsCant.Font = Helper.safeFont10;

      SetLeftVisibilityLbls(false);

      //stateLbl
      leftStateLbl.ForeColor = Helper.HexToColor(TUStrings.Colors.EARTHBORN_BUGLE);
      leftStateLbl.Text = TUStrings.LeftDataString.AUCTION;

      //titles lbls
      leftStateLbl.Text = TUStrings.LeftDataString.AUCTION;
      leftTitleA.Text = TUStrings.LeftDataString.HIGHEST_BIDDER;
      leftTitleB.Text = TUStrings.LeftDataString.END_TIME;
      leftTitleC.Text = TUStrings.LeftDataString.HIGHEST_BID;

      lblBeds.ForeColor =
      noBidInfo.ForeColor =
      leftTitleA.ForeColor =
      leftTitleB.ForeColor =
      leftTitleC.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);

      //desct lbls
      lblBedsCant.ForeColor =
      leftDescA.ForeColor =
      leftDescB.ForeColor =
      leftDescC.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
    }

    /// <summary>
    /// Establece el panel de vista.
    /// </summary>
    /// <param name="panel"></param>
    public void SetViewPanel(TUPanel panel)
    {
      panel.Controls.Clear();
      panel.Controls.Add(viewPanel);
    }

    /// <summary>
    /// Obtiene los mundos de Tibia.
    /// </summary>
    /// <returns></returns>
    private async Task GetWorlds()
    {
      worldsComboBox.SetText(TUStrings.LOADING);
      worldsComboBox.Enabled =
      showHousesBtn.Enabled =
      cleanBtn.Enabled = false;
      var worlds = await _worldController.GetWorlds();
      List<DropDownDataModel> data = new();
      int index = 0;
      if (worlds != null)
        foreach (var item in worlds.regular_worlds)
        {
          data.Add(new DropDownDataModel()
          {
            index = index++,
            text = item.name,
          });
        }
      else
        $"Error al cargar los mundos".ConsoleWL();

      worldsComboBox.Enabled =
      showHousesBtn.Enabled =
      cleanBtn.Enabled = true;
      worldsComboBox.SetText(TUStrings.WORLDS);
      worldsComboBox.SetData(data);
    }

    /// <summary>
    /// Muestra las casas en el mapa.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void showHousesBtn_Click(object sender, System.EventArgs e)
    {
      var selectedWorld = worldsComboBox.GetText();
      var selectedTown = townsComboBox.GetText();

      SetMapHouseView();
      SetLeftVisibilityLbls(false);

      if (selectedWorld == TUStrings.WORLDS)
      {
        //TODO: Mbox Personalizado
        "Selecciona un Mundo".Mbox();
        return;
      }

      if (selectedWorld != currentWorld)
      {
        _houseByIdCache.Clear();
        _housesByWorldCache.Clear();

        currentWorld = selectedWorld;
      }

      await DisposeHouseList();

      showHousesBtn.Enabled =
      cleanBtn.Enabled =
      worldsComboBox.Enabled =
      townsComboBox.Enabled =
      housesTypeComboBox.Enabled =
      houseStateComboBox.Enabled = false;

      List<Models.Houses.Houses> tempHousesByWorldList = new();

      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      switch (selectedTown)
      {
        case TUStrings.ALL_TOWNS:
          foreach (var townField in typeof(TUStrings.Towns).GetFields())
          {
            var townName = townField.GetValue(null).ToString();
            rightLblNoInfo.Text = $"Cargando info de {townName}";
            rightLblNoInfo.CenterControlToParent();

            var housesByTown = await LoadHousesByTown(selectedWorld, townName);
            tempHousesByWorldList.AddRange(housesByTown);
          }
          break;
        default:
          rightLblNoInfo.Text = $"Cargando info de {selectedTown}";
          rightLblNoInfo.CenterControlToParent();
          var housesBySelectedTown = await LoadHousesByTown(selectedWorld, selectedTown);
          tempHousesByWorldList.AddRange(housesBySelectedTown);
          break;
      }

      rightLblNoInfo.Visible = false;

      if (tempHousesByWorldList == null)
      {
        rightLblNoInfo.Visible = true;

        rightLblNoInfo.Text = TUStrings.HOUSES_NO_INFO;

        return;
      }

      #region Filtros
      // Crear una copia de los datos de la caché antes de aplicar los filtros
      var filteredHousesByWorldList = tempHousesByWorldList.Select(h => h.DeepCopy()).ToList();

      // Aplicar el filtro de tipo de casa después de cargar las casas
      var selectedHouseType = housesTypeComboBox.GetText();
      if (selectedHouseType != TUStrings.HouseType.ALL_HOUSES)
      {
        filteredHousesByWorldList = filteredHousesByWorldList?.Select(house =>
        {
          switch (selectedHouseType)
          {
            case TUStrings.HouseType.HOUSES:
              house.house_list = house.house_list?.Where(h => !h.name.Contains("Shop")).ToList();
              house.guildhall_list.Clear();
              break;
            case TUStrings.HouseType.SHOPS:
              house.house_list = house.house_list?.Where(h => h.name.Contains("Shop")).ToList();
              house.guildhall_list.Clear();
              break;
            case TUStrings.HouseType.GUILD_HALL:
              house.house_list.Clear();
              break;
          }
          return house;
        }).ToList();
      }

      //House State Filter
      var selectedHouseStatus = houseStateComboBox.GetText();
      if (selectedHouseStatus != TUStrings.HouseState.ALL_STATE)
      {
        filteredHousesByWorldList = filteredHousesByWorldList?.Select(house =>
        {
          switch (selectedHouseStatus)
          {
            case TUStrings.HouseState.AUCTIONED:
              house.house_list = house.house_list?.Where(h => h.auctioned).ToList();
              house.guildhall_list = house.guildhall_list?.Where(g => g.auctioned).ToList();
              break;
            case TUStrings.HouseState.RENTED:
              house.house_list = house.house_list?.Where(h => h.rented).ToList();
              house.guildhall_list = house.guildhall_list?.Where(g => g.rented).ToList();
              break;

            default:
              break;
          }
          return house;
        }).ToList();
      }
      #endregion

      foreach (var houses in filteredHousesByWorldList)
      {
        if (houses.house_list.Count == 0 && houses.guildhall_list.Count == 0)
        {
          continue;
        }
        List<House> townHouses = new();
        CustomControls.Houses.HousesList housesList = await housesListPool.Get();
        housesList.Name = houses.town;
#if DEBUG
        housesList.SetTitle($"{houses.town} ({houses.house_list.Count + houses.guildhall_list.Count})");
#else
        housesList.SetTitle(houses.town);
#endif
        housesList.AddHouseData(houses);
        housesList.HousesContainer = housesContainer;
        housesList.ScrollBar = rightScrollBar;
        housesList.parentHouses = this;
        housesList.PanelClick += HouseListTopBar_Click;
        housesList.MouseWheel += MouseWheelEvent;
        var nextLocY = housesContainer.Controls.Cast<Control>().Sum(c => c.Height);
        housesList.Top = nextLocY;
        housesContainer.Height += housesList.Height;
        housesContainer.Controls.Add(housesList);
        housesList.IsLoading = true;

        rightScrollBar.UpdateThumbHeight();

        Invalidate();
      }

      stopwatch.Stop();
      string elapsedTime = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");

      showHousesBtn.Enabled =
      cleanBtn.Enabled =
      worldsComboBox.Enabled =
      townsComboBox.Enabled =
      housesTypeComboBox.Enabled =
      houseStateComboBox.Enabled = true;
    }

    /// <summary>
    /// Carga las casas por mundo y ciudad.
    /// </summary>
    /// <param name="selectedWorld"></param>
    /// <param name="townName"></param>
    /// <returns></returns>
    private async Task<List<Models.Houses.Houses>> LoadHousesByTown(string selectedWorld, string townName)
    {
      Models.Houses.Houses houses = new();

      List<Models.Houses.Houses> tempHousesByWorldList = new();
      string cacheKey = $"{selectedWorld}_{townName}";
      if (_housesByWorldCache.TryGetValue(cacheKey, out houses))
      {
        var housesCopy = new Models.Houses.Houses()
        {
          house_list = houses.house_list.Select(h => h).ToList(),
          guildhall_list = houses.guildhall_list.Select(h => h).ToList(),
          town = houses.town
        };

        tempHousesByWorldList.Add(housesCopy);
      }
      else
      {
        List<Models.Houses.HousesList> sortedHouses = new();
        List<Models.Houses.GuildhallList> sortedGuildHall = new();
        houses = await Task.Run(() => _houseController.GetHousesByWorld(selectedWorld, townName)).ConfigureAwait(true);

        if (houses.house_list != null)
          sortedHouses.AddRange(houses.house_list.OrderBy(h => h.name, new NaturalOrderComparer()));
        if (houses.guildhall_list != null)
          sortedGuildHall.AddRange(houses.guildhall_list.OrderBy(h => h.name, new NaturalOrderComparer()));

        foreach (var gh in sortedGuildHall)
        {
          gh.name += " (Guildhall)";
        }

        houses.house_list = sortedHouses;
        houses.guildhall_list = sortedGuildHall;

        _housesByWorldCache[cacheKey] = houses;
        tempHousesByWorldList.Add(houses);
      }

      return tempHousesByWorldList;
    }

    /// <summary>
    /// Limpia las listas de casas.
    /// </summary>
    /// <returns></returns>
    private async Task DisposeHouseList()
    {

      housesContainer.Controls.Clear();
      housesContainer.Height = 0;

      rightScrollBar.UpdateThumbHeight();

      foreach (var item in gettedHousesList)
      {
        await item.DisposeHouseDataView();
        await housesListPool.Return(item);
        item.PanelClick -= HouseListTopBar_Click;
        item.MouseWheel -= MouseWheelEvent;
      }

      gettedHousesList.Clear();

      rightLblNoInfo.Visible = true;
      rightLblNoInfo.Text = TUStrings.HOUSES_NO_INFO;

    }

    /// <summary>
    /// Habilita o deshabilita las listas de casas.
    /// </summary>
    /// <param name="state">Estado de las listas de casas.</param>
    public void HousesListEnabled(bool state)
    {
      foreach (var item in gettedHousesList)
      {
        item.Enabled = state;
      }
    }

    /// <summary>
    /// Reposiciona las listas de casas en el contenedor.
    /// </summary>
    public void RelocateHousesLists()
    {
      var locationY = 0;

      foreach (CustomControls.Houses.HousesList item in housesContainer.Controls)
      {
        item.Location = new Point(0, locationY);
        locationY += item.Height;
        if (!item.IsLoading)
        {
        }
      }

      housesContainer.Height = housesContainer.Controls.Cast<Control>().LastOrDefault().Bottom;
    }

    /// <summary>
    /// Limpia las listas de casas.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void cleanBtn_Click(object sender, System.EventArgs e)
    {
      await DisposeHouseList();
      SetLeftVisibilityLbls(false);
      SetMapHouseView();
    }

    /// <summary>
    /// Muestra la vista de la casa seleccionada en el mapa.
    /// </summary>
    /// <param name="url">URL de la imagen de la casa.</param>
    private void SetMapHouseView(string url = "")
    {

      string imgURL =  url != "" ? $"<img src='{url}'>" : string.Empty;

      string htmlContent = $@"
      <!DOCTYPE html>
      <html>
      <head>
          <style>
              html, body {{
                  margin: 0;
                  padding: 0;
                  width: 100%;
                  height: 100%;
                  background-image: url('data:image/png;base64,{backgroundImageBase64}');
                  background-size: 100%
                  background-position: center;
                  overflow: hidden;
              }}
              img {{
                  width: 100%;
                  height: 100%;
              }}
          </style>
      </head>
      <body>
          {imgURL}
      </body>
      </html>";

      houseMapImg.DocumentText = htmlContent;
    }
  }
}
