using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Lib;

namespace TibiaUtilities.CustomControls.BaseControl
{
  public partial class DisplayDataPanel : UserControl
  {
    private TUFunctions.SliceType sliceType = TUFunctions.SliceType.NineSlice;
    private Rectangle[] slices;
    private int cornerWidth = 5;
    private int cornerHeight = 17;

    private bool isMinimizable = false;
    private bool isMinimized = false;

    [Browsable(true)]
    [DefaultValue(false)]
    public bool IsMinizable
    {
      get => isMinimizable;
      set
      {
        isMinimizable = value;
      }
    }

    public int CornerWidth
    {
      get { return cornerWidth; }
      set
      {
        if (cornerWidth != value)
        {
          cornerWidth = value;
          slices = TUHelper.TUFunctions.CalculateSlices(BackgroundImage, sliceType, cornerWidth, cornerHeight);
          this.Invalidate();
        }
      }
    }

    public int CornerHeight
    {
      get { return cornerHeight; }
      set
      {
        if (cornerHeight != value)
        {
          cornerHeight = value;
          slices = TUHelper.TUFunctions.CalculateSlices(BackgroundImage, sliceType, cornerWidth, cornerHeight);
          this.Invalidate();
        }
      }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [Description("Tipo de división de la imagen de fondo")]
    [DefaultValue(TUFunctions.SliceType.None)]
    public TUFunctions.SliceType SliceType
    {
      get { return sliceType; }
      set
      {
        if (sliceType != value)
        {
          sliceType = value;
          slices = TUHelper.TUFunctions.CalculateSlices(BackgroundImage, sliceType, cornerWidth, cornerHeight);
          Invalidate();
        }
      }
    }

    public int MaxHeight { get; set; }
    public TUPanel TopPanel { get { return topPanel; } }

    public DisplayDataPanel()
    {
      InitializeComponent();
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      title.ForeColor = TUFonts.Title.TextColor;
      title.Click += (s, e) => { MinAndMaxPanel(); };
      topPanel.Click += (s, e) => { MinAndMaxPanel(); };
    }

    public void SetTitle(string text)
    {
      title.Text = text;
      title.Left = (this.Width - title.Width) / 2;
    }

    private void DisplayDataPanel_Resize(object sender, EventArgs e)
    {
      title.Left = (this.Width - title.Width) / 2;
    }

    private void MinAndMaxPanel()
    {
      if (isMinimizable)
      {
        this.Height = !isMinimized ? this.topPanel.Height : 129;
        isMinimized = !isMinimized;
      }
    }


  }
}