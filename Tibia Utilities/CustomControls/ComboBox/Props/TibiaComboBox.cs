using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
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
    private List<TULabel> currentLabels = new();
    private string _text = string.Empty;

    [Browsable(false)]
    public TCBDropDown DropDownPanel { get => dropDownPanel; }

    public TUPanel MainView { get; set; }

    public TibiaComboBox()
    {
      InitializeComponent();

      DoubleBuffered = true;

      lblWorld.Font =
      lblDrop.Font = Helper.safeFont8;

      lblWorld.ForeColor =
      lblDrop.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);

      lblDrop.CenterControlToParent();
      lblWorld.CenterControlToParent();

      dropBtn.Click += ComboBtn_Click;
      dropBtn.MouseDown += ComboBtns_MouseDown;
      dropBtn.MouseUp += ComboBtns_MouseUp;

      lblDrop.Click += ComboBtn_Click;
      lblDrop.MouseDown += ComboBtns_MouseDown;
      lblDrop.MouseUp += ComboBtns_MouseUp;

      worldBtn.Click += ComboBtn_Click;
      worldBtn.MouseDown += ComboBtns_MouseDown;
      worldBtn.MouseUp += ComboBtns_MouseUp;

      lblWorld.Click += ComboBtn_Click;
      lblWorld.MouseDown += ComboBtns_MouseDown;
      lblWorld.MouseUp += ComboBtns_MouseUp;

      _dropDownMessageFilter = new(this);

      dropDownPanel.TibiaComboBox = this;

    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      dropDownPanel.Visible = false;
      MainView?.Controls.Add(dropDownPanel);
      dropDownPanel.BringToFront();
      dropDownPanel.Width = Width;
      dropDownPanel.Location = new Point(Left, Bottom);
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      lblWorld.CenterControlToParent();
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

    public void UpdateBtnsState()
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

    public void SetText(string text)
    {
      lblWorld.Text = Text = text;
      lblWorld.CenterControlToParent();
    }

    public string GetText()
    {
      return lblWorld.Text;
    }

    internal void HideDropDown()
    {
      Application.RemoveMessageFilter(_dropDownMessageFilter);
      Application.DoEvents();

      boxState = ComboBoxState.Normal;

      foreach (var lbl in currentLabels)
      {
        Task.WaitAny(Helper.LabelsPool.Return(lbl));
      }

      currentLabels.Clear();

      UpdateBtnsState();
    }
  }
}
