using System;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.Houses;

namespace Tibia_Utilities.CustomControls.Houses
{
  public partial class HouseDataView : UserControl
  {
    public event EventHandler<HouseDataView> HouseDataClick;

    public HouseDataView()
    {
      InitializeComponent();

      DoubleBuffered = true;

      SetLabels();

      AssignClickEvents();
    }

    private void HouseData_Click(object sender, EventArgs e)
    {
      //BackColor = clicked ? Color.Transparent : Color.White;
      //clicked = !clicked;

      HouseDataClick?.Invoke(this, this);
    }

    private void AssignClickEvents()
    {
      // Lista de controles que necesitan el evento
      Control[] controls = {
              this, lblSize, lblSqm, lblRent, lblCantRent, lblAuction,
              lblStatus, lblDesc, topPanel, lblName, coinImg, shopImg, viewPort
          };

      // Asignar el evento a cada control
      foreach (var control in controls)
      {
        control.Click += HouseData_Click;
      }
    }

    private void SetLabels()
    {
      lblName.Font = Helper.safeFont10;
      lblName.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);
      lblName.CenterControlToParent();

      lblSize.ForeColor =
      lblRent.ForeColor =
      lblStatus.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);

      lblSqm.ForeColor =
      lblCantRent.ForeColor =
      lblDesc.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      foreach (Control control in viewPort.Controls)
      {
        if (control is Label lbl)
        {
          lbl.Font = Helper.safeFont9;
          lbl.BackColor = Color.Transparent;
        }
      }
    }

    public void SetData(HousesListParseModel house)
    {
      if (InvokeRequired)
      {
        Invoke((MethodInvoker)(() => SetData(house)));
        return;
      }

      // Actualiza la UI con los datos de la casa
      lblName.Text = house.name;
      lblName.CenterControlToParent();
      lblSqm.Text = house.size.ToString("N0");
      lblCantRent.Text = Helper.FormatTibiaGold(house.rent);

      if (house.auctioned)
      {
        lblAuction.ForeColor = Helper.HexToColor(TUStrings.Colors.POSI_TEXT_COLOR);
        lblAuction.Text = $"{TUStrings.AUCTIONED}";

        if (house.auction.current_bid > 0)
        {
          lblDesc.Text = $" (Bid:  {house.auction.current_bid.ToString("N0")} gp  ends  in  {house.auction.time_left})";
        }
        else
          lblDesc.Text = $"({TUStrings.NO_BID})";
      }
      else if (house.rented)
      {
        lblAuction.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
        lblAuction.Text = $"{TUStrings.RENTED}";
        lblDesc.Text = string.Empty;
      }

      if (house.name.Contains("(Shop)"))
        shopImg.Visible = true;
      else
        shopImg.Visible = false;

      Tag = house;
    }

    public HousesListParseModel GetData()
    {
      return Tag as HousesListParseModel;
    }

    public void DataSelected(bool isSelected)
    {
      BackColor = isSelected ? Color.White : Color.Transparent;
    }

    public void DisposeData()
    {
      BackColor = Color.Transparent;
    }

    public override string ToString()
    {
      var h = GetData();
      if (h == null) return base.ToString();

      return h.DeepInfoToString();
    }

    public string PrintDeepData()
    {
      var h = GetData();
      if (h == null) return string.Empty;
      return h.DeepInfoToString();
    }
  }
}
