using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models;

namespace Tibia_Utilities.CustomControls.ComboBox.Props
{
  public partial class TCBDropDown : UserControl
  {
    private const int CONTAINER_MAX_HEIGHT = 345;

    private List<DropDownDataModel> dataCache = new();

    public List<DropDownDataModel> DataCache { get => dataCache; }

    public TCBDropDown()
    {
      InitializeComponent();
      DoubleBuffered = true;
    }

    public async void AddData(List<DropDownDataModel> data)
    {
      var lbls = Helper.labelsPool;
      dataCache = data;
      foreach (var item in data)
      {
        var lbl = await lbls.Get();
        lbl.AutoSize = false;
        lbl.TextAlign = ContentAlignment.MiddleLeft;
        lbl.Text = item.text;
        lbl.Font = Helper.safeFont8;
        lbl.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
        lbl.Tag = item.index;
        lbl.MouseHover += Lbl_MouseHover;
        lbl.MouseLeave += Lbl_MouseLeave;
        viewPort.Controls.Add(lbl);
        viewPort.Height += lbl.Height;
        if (container.Height < CONTAINER_MAX_HEIGHT)
        {
          Height = viewPort.Height;
        }
        lbl.Dock = DockStyle.Bottom;
      }

      scrollBar.UpdateThumbHeight();
    }

    private void Lbl_MouseLeave(object sender, System.EventArgs e)
    {
      var lbl = sender as Label;
      lbl.BackColor = Color.Transparent;
      lbl.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
    }

    private void Lbl_MouseHover(object sender, System.EventArgs e)
    {
      var lbl = sender as Label;
      lbl.BackColor = Color.FromArgb(50, 211, 211, 211);
      lbl.ForeColor = Helper.HexToColor(TUStrings.Colors.WHITE_SIGNAL_TEXT_COLOR);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);
      scrollBar.MoveThumbByWheel(e.Delta);
    }

    private void TCBDropDown_Resize(object sender, System.EventArgs e)
    {
      viewPort.Width = container.Width - scrollBar.Width;
    }

    public void Clear()
    {
      viewPort.Controls.Clear();
      viewPort.Height = 0;
    }
  }
}
