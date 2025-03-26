using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.Houses;

namespace Tibia_Utilities.CustomControls.Houses
{
  public partial class HousesList : UserControl
  {
    public event EventHandler<HousesList> PanelClick;

    private List<HouseDataView> gettedHouseDataViewPool = new ();

    private List<HousesListParseModel> houseListCache = new();

    private bool minimized = true;
    private TUPanel _housesContainer;
    private TibiaVScrollBar _scrollBar; // Referencia al scrollbar
    private int expandHeight = 0;

    public Views.Panels.Houses parentHouses { get; set; }
    public bool IsLoading { get; set; }

    [Browsable(true)]
    [Category("Custom Props")]
    [Description("Get or Set the ViewPort")]
    public TUPanel HousesContainer
    {
      get { return _housesContainer; }
      set { _housesContainer = value; }
    }

    [Browsable(true)]
    [Category("Custom Props")]
    [Description("Get or Set the ScrollBar")]
    public TibiaVScrollBar ScrollBar
    {
      get { return _scrollBar; }
      set { _scrollBar = value; }
    }

    public bool Minimized { get => minimized; set => minimized = value; }

    public HousesList()
    {
      InitializeComponent();

      DoubleBuffered = true;

      Task.Run(() => DisposeHouseDataView());

      lblName.Font = Helper.safeFont10;
      lblName.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);
      lblName.CenterControlToParent();

      AssingClickEvents();
    }

    private void AssingClickEvents()
    {
      Control[] controls = { lblName, topPanel };
      foreach (var control in controls)
      {
        control.Click += TopPanel_Click;
      }
    }

    private void TopPanel_Click(object sender, EventArgs e)
    {
      minimized = !minimized;

      PanelClick?.Invoke(this, this);
    }

    public void AddHouseData(Models.Houses.Houses housesData)
    {
      foreach (var house in housesData.house_list)
      {
        HousesListParseModel tempHouse = new();
        tempHouse.SetData(house);
        houseListCache.Add(tempHouse);
      }

      foreach (var gh in housesData.guildhall_list)
      {
        HousesListParseModel tempHouse = new();
        tempHouse.SetData(gh);
        houseListCache.Add(tempHouse);
      }

      expandHeight = (houseListCache.Count * 75) + (topPanel.Height + 5);
    }

    public async Task ShowHouseDataView()
    {
      int locationY = 0;

      parentHouses.HousesListEnabled(false);

      List<HouseDataView> list = new();

      foreach (var house in houseListCache)
      {
        var houseDataView = await Helper.HouseDataViewPool.Get();
        gettedHouseDataViewPool.Add(houseDataView);
        houseDataView.Name = house.name;
        houseDataView.SetData(house);
        houseDataView.HouseDataClick += parentHouses.OnHouseDataViewClick;

        houseDataView.Dock = DockStyle.Bottom;
        list.Add(houseDataView);
        locationY += houseDataView.Height;

        // Actualizar el scrollbar
        _scrollBar?.UpdateThumbHeight();
        _scrollBar.Update();

        Update();
        Invalidate();

      }

      Height = expandHeight;
      container.Controls.AddRange(list.ToArray());
      parentHouses.HousesListEnabled(true);

      ScrollBar.UpdateThumbHeight();

    }

    public void SetTitle(string townName)
    {
      lblName.Text = townName;
      lblName.CenterControlToParent(System.Drawing.ContentAlignment.MiddleLeft);
    }

    public void UpdateHouseDataViewVisibles()
    {
      if (!minimized)
      {

      }
    }

    public async Task DisposeHouseDataView()
    {
      foreach (var houseDataView in gettedHouseDataViewPool)
      {
        houseDataView.DisposeData();
        houseDataView.HouseDataClick -= parentHouses.OnHouseDataViewClick;
        await Helper.HouseDataViewPool.Return(houseDataView);
      }
      gettedHouseDataViewPool.Clear();
      Height = topPanel.Height + 5;
      minimized = true;
      container.Controls.Clear();
    }

    public string GetTitle()
    {
      return lblName.Text;
    }
  }
}
