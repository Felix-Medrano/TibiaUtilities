using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models;

namespace Tibia_Utilities.CustomControls.ComboBox.Props
{
  public partial class TCBDropDown : UserControl
  {
    public event EventHandler<DropDownDataModel> LabelClick;

    private const int CONTAINER_MAX_HEIGHT = 345;

    private List<DropDownDataModel> dataCache = new();

    public List<DropDownDataModel> DataCache { get => dataCache; }

    public TibiaComboBox TibiaComboBox { get; set; }

    public TCBDropDown()
    {
      InitializeComponent();
      DoubleBuffered = true;
    }

    private void Lbl_Click(object sender, EventArgs e)
    {
      var lbl = sender as Label;
      var tag = lbl.Tag as DropDownDataModel;
      LabelClick?.Invoke(lbl, tag);
    }

    public async void AddData(List<DropDownDataModel> data)
    {
      var lbls = Helper.LabelsPool;
      container.Height = 0;

      dataCache = data;
      foreach (var item in data)
      {
        var lbl = await lbls.Get();
        lbl.AutoSize = false;
        lbl.TextAlign = ContentAlignment.MiddleLeft;
        lbl.Text = item.text;
        lbl.Font = Helper.safeFont8;
        lbl.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
        lbl.Dock = DockStyle.Bottom;
        lbl.Tag = item;
        lbl.TibiaComboBox = TibiaComboBox;
        lbl.MouseLeave += Lbl_MouseLeave;
        lbl.MouseEnter += Lbl_MouseEnter;
        lbl.Click += Lbl_Click;
        container.Controls.Add(lbl);
        container.Height += lbl.Height;
        if (container.Height < CONTAINER_MAX_HEIGHT)
        {
          Height = container.Height + backgroundPanel.Padding.Top + backgroundPanel.Padding.Bottom;
        }
        lbl.Dock = DockStyle.Bottom;
      }

      scrollBar.UpdateThumbHeight();
    }

    private void Lbl_MouseEnter(object sender, System.EventArgs e)
    {
      var lbl = sender as Label;
      lbl.BackColor = Color.FromArgb(50, 211, 211, 211);
      lbl.ForeColor = Helper.HexToColor(TUStrings.Colors.WHITE_SIGNAL_TEXT_COLOR);
    }

    private void Lbl_MouseLeave(object sender, System.EventArgs e)
    {
      var lbl = sender as Label;
      lbl.BackColor = Color.Transparent;
      lbl.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
      base.OnMouseWheel(e);
      scrollBar.MoveThumbByWheel(e.Delta);
    }

    private void TCBDropDown_Resize(object sender, System.EventArgs e)
    {
      container.Width = viewPort.Width - scrollBar.Width;
    }

    public void Clear()
    {
      container.Controls.Clear();
      container.Height = 0;
    }
  }
}
