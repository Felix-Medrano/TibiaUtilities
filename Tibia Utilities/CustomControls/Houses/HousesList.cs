using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tibia_Utilities.Core;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.Houses;

namespace Tibia_Utilities.CustomControls.Houses
{
  public partial class HousesList : UserControl
  {
    public event EventHandler PanelClick;

    private ObjectPool<HouseDataView> houseDataViewPool = new ObjectPool<HouseDataView>(70);
    private List<HouseDataView> gettedHouseDataViewPool = new ();

    private List<House> houseListCache = new();

    private bool minimized = false;
    private TUPanel _viewPort;
    private TibiaVScrollBar _scrollBar; // Referencia al scrollbar

    [Browsable(true)]
    [Category("Custom Props")]
    [Description("Get or Set the ViewPort")]
    public TUPanel ViewPort
    {
      get { return _viewPort; }
      set { _viewPort = value; }
    }

    [Browsable(true)]
    [Category("Custom Props")]
    [Description("Get or Set the ScrollBar")]
    public TibiaVScrollBar ScrollBar
    {
      get { return _scrollBar; }
      set { _scrollBar = value; }
    }

    private int maxHeigth;
    public HousesList()
    {
      InitializeComponent();

      DoubleBuffered = true;

      lblName.Font = Helper.safeFont10;
      lblName.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);
      lblName.CenterControlToParent();

      AssingClickEvents();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateView();
    }

    private void AssingClickEvents()
    {
      Control[] controls = { lblName, topPanel };
      foreach (var control in controls)
      {
        control.Click += TopPanel_Click;
      }
    }

    private async void TopPanel_Click(object sender, EventArgs e)
    {
      minimized = !minimized;

      if (!minimized)
      {
        foreach (var houseDataView in gettedHouseDataViewPool)
        {
          houseDataView.Clear();
          await houseDataViewPool.Return(houseDataView);
        }
        gettedHouseDataViewPool.Clear();
        container.Height = 0;
        container.Controls.Clear();
      }
      else
      {
        await AddHouseDataView();
      }

      UpdateView();

      PanelClick?.Invoke(this, e);
    }

    private void UpdateView()
    {
      Height = minimized ? maxHeigth : topPanel.Height + 5;
      _viewPort.Height = Height;

      Update();
      Invalidate();
    }

    public void AddHouseData(List<House> houseData)
    {
      if (houseListCache != null)
        houseListCache = houseData;
    }

    private async Task AddHouseDataView()
    {
      int locationY = 0;
      maxHeigth = topPanel.Height + 5;

      foreach (var house in houseListCache)
      {
        var houseDataView = await houseDataViewPool.Get();
        gettedHouseDataViewPool.Add(houseDataView);
        houseDataView.SetData(house);

        houseDataView.Location = new Point(0, locationY);
        container.Controls.Add(houseDataView);

        locationY += houseDataView.Height;
        maxHeigth += houseDataView.Height;

        container.Height = maxHeigth - 2;
        Height = maxHeigth;
        UpdateView();

        // Actualizar el scrollbar
        _scrollBar?.UpdateThumbHeight();
        _scrollBar.Update();

      }
    }
  }
}
