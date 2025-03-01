using System;
using System.Collections.Generic;
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

    private WorldController _worldController = new WorldController();
    private HouseController _houseController = new HouseController();

    private ObjectPool<HouseList> housesListPool;

    private Worlds _worlds;
    private House _house;
    private Models.Houses.Houses _houses;

    private List<House> houses = new();

    int locationY = 0;

    public Houses()
    {
      InitializeComponent();

      var countTowns = typeof(TUStrings.Towns).GetFields().Length;

      housesListPool = new ObjectPool<HouseList>(countTowns);

      SetLblsNoInfo();

      var GetWorldTask = GetWorlds();

      var GetHouseTask = GetHousesByWorld();

      rightScrollBar.UpdateThumbHeight();
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);

      rightScrollBar.MoveThumbByWheel(e.Delta);
    }

    public void HouseListTopBar_Click(object sender, EventArgs e)
    {
      rightScrollBar.UpdateThumbHeight();
    }

    private void MouseWheelEvent(object sender, MouseEventArgs e)
    {
      OnMouseWheel(e);
    }

    private void SetLblsNoInfo()
    {
      leftLblNoInfo.Font =
      rightLblNoInfo.Font = Helper.safeFont12;

      leftLblNoInfo.ForeColor =
      rightLblNoInfo.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      leftLblNoInfo.Text =
      rightLblNoInfo.Text = "No hay información disponible.";

      leftLblNoInfo.CenterControlToParent();
      rightLblNoInfo.CenterControlToParent();
    }

    public void SetViewPanel(TUPanel panel)
    {
      panel.Controls.Clear();
      panel.Controls.Add(viewPanel);
    }

    private async Task GetWorlds()
    {
      var worlds = await _worldController.GetWorlds();
      List<DropDownDataModel> data = new();
      int index = 0;
      foreach (var item in worlds.regular_worlds)
      {
        data.Add(new DropDownDataModel()
        {
          index = index++,
          text = item.name,
        });

      }

      tibiaComboBox1.SetData(data);
    }

    private async Task GetHouseById(string world = "Secura", int id = 35019)
    {

      _house = await _houseController.GetHouseById(world, id);
      if (_house != null)
      {
        houses.Add(_house);
      }
    }

    private async Task GetHousesByWorld(string world = "Secura", string town = "Venore")
    {
      _houses = await _houseController.GetHousesByWorld(world, town);

      if (_houses != null)
        leftLblNoInfo.Visible =
        rightLblNoInfo.Visible = false;

      List<Task> houseTasks = new List<Task>();

      foreach (var house in _houses.house_list)
      {
        await GetHouseById(world, house.house_id);
      }

      foreach (var house in _houses.guildhall_list)
      {
        await GetHouseById(world, house.house_id);
      }

      await Task.WhenAll(houseTasks);

      HousesList houseList = new();
      houseList.ViewPort = houseViewport;
      houseList.ScrollBar = rightScrollBar;
      houseList.AddHouseData(houses);
      houseList.Location = new System.Drawing.Point(0, 0);
      houseList.Dock = DockStyle.Top;
      houseList.PanelClick += HouseListTopBar_Click;
      houseList.MouseWheel += MouseWheelEvent;
      houseViewport.Controls.Add(houseList);
      houseViewport.Height = houseList.Height;

      Invalidate(houseViewport.Bounds);
    }
  }
}
