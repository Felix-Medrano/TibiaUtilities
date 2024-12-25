using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Lib;

namespace TibiaUtilities.CustomControls
{
  public class TUControlButton : Control
  {
    public new event EventHandler Click;

    private Rectangle[] slices;
    private TUFunctions.SliceType sliceType = TUFunctions.SliceType.None;
    private Size defSize                    = new Size(50,50);
    private Point imageLocation             = Point.Empty;
    private Image image                     = null;
    private bool pressed                    = false;
    private bool isDrawing                  = false;
    private bool drawText                   = false;
    private int cornerWidth                 = 10;
    private int cornerHeight                = 10;

    public bool DrawText
    {
      get { return drawText; }
      set
      {
        drawText = value;
        Invalidate();
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

    public override Image BackgroundImage
    {
      get => base.BackgroundImage;
      set
      {
        base.BackgroundImage = value;
        Invalidate();
        this.Size = value != null ? value.Size : defSize;
      }
    }

    public Image Image
    {
      get => image;
      set
      {
        image = value;
        Invalidate();
      }
    }

    public override string Text
    {
      get => base.Text;
      set
      {
        base.Text = value;
        Invalidate();
      }
    }

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

    public TUControlButton()
    {
      this.DoubleBuffered = true;
      ForeColor = TUColors.TV_GRAY;
      Font = TUFonts.Description.TextFont;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      isDrawing = true;

      base.OnPaint(e);

      //if (this.BackgroundImage == null || slices == null) return;

      Graphics g = e.Graphics;

      if (BackgroundImage != null)
        switch (sliceType)
        {
          case TUFunctions.SliceType.None:
            g.DrawImage(this.BackgroundImage, new Rectangle(0, 0, Width, Height));
            break;

          case TUFunctions.SliceType.NineSlice:
            // Esquinas
            g.DrawImage(this.BackgroundImage, new Rectangle(0, 0, cornerWidth, cornerHeight), slices[0], GraphicsUnit.Pixel);
            g.DrawImage(this.BackgroundImage, new Rectangle(Width - cornerWidth, 0, cornerWidth, cornerHeight), slices[2], GraphicsUnit.Pixel);
            g.DrawImage(this.BackgroundImage, new Rectangle(0, Height - cornerHeight, cornerWidth, cornerHeight), slices[6], GraphicsUnit.Pixel);
            g.DrawImage(this.BackgroundImage, new Rectangle(Width - cornerWidth, Height - cornerHeight, cornerWidth, cornerHeight), slices[8], GraphicsUnit.Pixel);

            // Bordes
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[1], cornerWidth, 0, Width - 2 * cornerWidth, cornerHeight);
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[7], cornerWidth, Height - cornerHeight, Width - 2 * cornerWidth, cornerHeight);
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[3], 0, cornerHeight, cornerWidth, Height - 2 * cornerHeight);
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[5], Width - cornerWidth, cornerHeight, cornerWidth, Height - 2 * cornerHeight);

            // Centro
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[4], cornerWidth, cornerHeight, Width - 2 * cornerWidth, Height - 2 * cornerHeight);
            break;

          case TUFunctions.SliceType.ThreeSliceVertical:
            // Top
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[0], 0, 0, Width, cornerHeight);
            // Middle
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[1], 0, cornerHeight, Width, Height - 2 * cornerHeight);
            // Bottom
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[2], 0, Height - cornerHeight, Width, cornerHeight);
            break;

          case TUFunctions.SliceType.ThreeSliceHorizontal:
            // Left
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[0], 0, 0, cornerWidth, Height);
            // Center
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[1], cornerWidth, 0, Width - 2 * cornerWidth, Height);
            // Right
            TUHelper.TUFunctions.DrawRepeatedSlice(g, BackgroundImage, slices[2], Width - cornerWidth, 0, cornerWidth, Height);
            break;
        }

      if (pressed)
      {
        using (Pen pen = new Pen(Color.Black, 2))
        {
          e.Graphics.DrawLine(pen, 0, 0, this.Width, 0);
          e.Graphics.DrawLine(pen, 0, 0, 0, this.Height);
          e.Graphics.DrawLine(pen, this.Width, this.Height, 0, this.Height);
          e.Graphics.DrawLine(pen, this.Width, this.Height, this.Width, 0);
        }
      }

      if (image != null)
      {
        int offset = pressed ? 1 : 0;

        int x = (this.Width - image.Width) / 2 + offset;
        int y = (this.Height - image.Height) / 2 + offset;
        e.Graphics.DrawImage(image, x, y, image.Width, image.Height);
      }

      if (!string.IsNullOrEmpty(Text) && drawText)
      {
        using (StringFormat sf = new StringFormat())
        {
          sf.Alignment = StringAlignment.Center;
          sf.LineAlignment = StringAlignment.Center;

          using (Brush brush = new SolidBrush(ForeColor))
          {
            g.DrawString(Text, Font, brush, ClientRectangle, sf);
          }
        }
      }

      isDrawing = false;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (isDrawing) return;

      if (e.Button == MouseButtons.Left)
      {
        base.OnMouseDown(e);
        pressed = true;
        this.Invalidate();
      }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      if (isDrawing) return;

      pressed = false;

      if (e.Button == MouseButtons.Left)
      {
        base.OnMouseUp(e);
        if (ClientRectangle.Contains(e.Location))
        {
          Click?.Invoke(this, EventArgs.Empty);
          Console.WriteLine("Click");
        }
        this.Invalidate();
      }
    }
  }
}
