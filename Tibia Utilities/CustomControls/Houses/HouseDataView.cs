using System;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.Houses;

namespace Tibia_Utilities.CustomControls.Houses
{
  public partial class HouseDataView : UserControl
  {
    private bool clicked = false;

    public HouseDataView()
    {
      InitializeComponent();

      DoubleBuffered = true;

      SetLabels();

      AssignClickEvents();
    }

    private void HouseData_Click(object sender, EventArgs e)
    {
      BackColor = clicked ? Color.Transparent : Color.White;
      clicked = !clicked;
    }

    private void AssignClickEvents()
    {
      // Lista de controles que necesitan el evento
      Control[] controls = {
              this, lblSize, lblSqm, lblBeds, lblCantBeds, lblRent, lblCantRent,
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
      lblBeds.ForeColor =
      lblRent.ForeColor =
      lblStatus.ForeColor = Helper.HexToColor(TUStrings.Colors.TITLE_TEXT_COLOR);

      lblSqm.ForeColor =
      lblCantBeds.ForeColor =
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

    public void SetData(House house)
    {
      if (InvokeRequired)
      {
        Invoke((MethodInvoker)(() => SetData(house)));
        return;
      }

      // Actualiza la UI con los datos de la casa
      lblName.Text = house.name;
      lblSqm.Text = house.size.ToString("N0");
      lblCantBeds.Text = house.beds.ToString("N0");
      lblCantRent.Text = Helper.FormatTibiaGold(house.rent);
      lblDesc.Text = house.status.is_rented ? "Alquilada" : "Disponible";
    }

    public void Clear()
    {
      BackColor = Color.Transparent;
      clicked = false;
      Location = new Point(0, 0);
    }
  }
}
