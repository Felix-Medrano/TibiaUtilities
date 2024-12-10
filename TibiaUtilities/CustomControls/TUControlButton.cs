using System;
using System.Drawing;
using System.Windows.Forms;

namespace TibiaUtilities.CustomControls
{
  public class TUControlButton : Control
  {
    public new event EventHandler Click;

    private Size defSize        = new Size(50,50);
    private Point imageLocation = Point.Empty;
    private Image image         = null;
    private bool pressed        = false;
    private bool press          = false;
    private bool isDrawing      = false;

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

    public TUControlButton()
    {
      this.DoubleBuffered = true;
    }

    protected override void OnClick(EventArgs e) => Click?.Invoke(this, e);

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      isDrawing = true;

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
          OnClick(EventArgs.Empty);
        }
        this.Invalidate();
      }
    }
  }
}
