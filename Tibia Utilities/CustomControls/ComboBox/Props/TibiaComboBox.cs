using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.CustomControls.ComboBox.Props;
using Tibia_Utilities.Lib;
using Tibia_Utilities.Models;
using Tibia_Utilities.Properties;

namespace Tibia_Utilities.CustomControls
{
  public enum ComboBoxState
  {
    Normal,
    Pressed,
    Hover
  }

  public partial class TibiaComboBox : UserControl
  {
    private ComboBoxState boxState = ComboBoxState.Normal;

    private TCBDropDown dropDownPanel = new();

    private DropDownMessageFilter _dropDownMessageFilter;
    private List<Label> currentLabels = new();

    [Browsable(false)]
    public TCBDropDown DropDownPanel { get => dropDownPanel; }

    public TUPanel MainView { get; set; }

    public TibiaComboBox()
    {
      InitializeComponent();

      DoubleBuffered = true;

      dropBtn.Click += ComboBtn_Click;
      dropBtn.MouseDown += ComboBtns_MouseDown;
      dropBtn.MouseUp += ComboBtns_MouseUp;

      worldBtn.Click += ComboBtn_Click;
      worldBtn.MouseDown += ComboBtns_MouseDown;
      worldBtn.MouseUp += ComboBtns_MouseUp;

      _dropDownMessageFilter = new(this);

    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      dropDownPanel.Visible = false;
      MainView.Controls.Add(dropDownPanel);
      dropDownPanel.BringToFront();
      dropDownPanel.Width = Width;
      dropDownPanel.Location = new Point(Left, Bottom);
    }

    private void ComboBtn_Click(object sender, EventArgs e)
    {
      switch (boxState)
      {
        case ComboBoxState.Normal:
          boxState = ComboBoxState.Pressed;
          break;
        case ComboBoxState.Pressed:
          boxState = ComboBoxState.Normal;
          break;
        case ComboBoxState.Hover:
          //Do_Nothing
          break;
      }
    }

    private void ComboBtns_MouseDown(object sender, MouseEventArgs e)
    {
      dropBtn.OriginalImage =
      worldBtn.OriginalImage = Resources.BorderedPanel;

      Helper.Sounds.PlayPressButtonSound();
    }

    private void ComboBtns_MouseUp(object sender, MouseEventArgs e)
    {
      UpdateBtnsState();

      Helper.Sounds.PlayReleaseButtonSound();
    }

    public async void UpdateBtnsState()
    {
      Bitmap img = null;
      switch (boxState)
      {
        case ComboBoxState.Normal:
          img = Resources.RaisedPanel;
          dropDownPanel.Visible = false;
          break;
        case ComboBoxState.Pressed:
          img = Resources.BorderedPanel;
          dropDownPanel.Visible = true;
          Application.AddMessageFilter(_dropDownMessageFilter);
          break;
        case ComboBoxState.Hover:
          //Do_Nothing
          break;
      }
      dropBtn.OriginalImage =
      worldBtn.OriginalImage = img;
    }

    public void SetData(List<DropDownDataModel> data)
    {
      dropDownPanel.Clear();
      dropDownPanel.AddData(data);
    }

    internal void HideDropDown()
    {
      Application.RemoveMessageFilter(_dropDownMessageFilter);
      Application.DoEvents();

      boxState = ComboBoxState.Normal;

      foreach (var lbl in currentLabels)
      {
        Helper.labelsPool.Return(lbl);
      }

      currentLabels.Clear();

      UpdateBtnsState();
    }
  }
}
