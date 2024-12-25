using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Properties;

namespace TibiaUtilities.CustomControls
{
  public class TUButton : Control
  {
    public new event EventHandler Click;

    private Size defSize        = new Size(50,50);
    private Point imageLocation = Point.Empty;
    private Image image         = null;
    private bool pressed        = false;
    private bool isDrawing      = false;
    private bool isMaximized     = false;

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

    public override string Text
    {
      get => base.Text;
      set
      {
        base.Text = value;
        Invalidate();
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

    public bool IsMAximized
    {
      get => isMaximized;
      set
      {
        isMaximized = value;
        Invalidate();
      }
    }

    public TUButton()
    {
      this.DoubleBuffered = true;
    }

    protected override void OnClick(EventArgs e) => Click?.Invoke(this, e);

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      isDrawing = true;

      if (pressed && !isMaximized)
      {
        using (Pen pen = new Pen(Color.Black, 1))
        {
          e.Graphics.DrawLine(pen, 0, 0, this.Width, 0);
          e.Graphics.DrawLine(pen, 0, 0, 0, this.Height);
          e.Graphics.DrawLine(pen, this.Width, this.Height, 0, this.Height);
          e.Graphics.DrawLine(pen, this.Width, this.Height, this.Width, 0);
        }
      }

      if (image != null)
      {
        int offset = pressed ? 2 : 0;

        if (!isMaximized)
        {
          int x = (this.Width - image.Width) / 2 + offset;
          int y = (this.Height - image.Height) / 2 + offset;
          imageLocation = new Point(x, y);
        }
        e.Graphics.DrawImage(image, imageLocation.X, imageLocation.Y, image.Width, image.Height);
      }

      if (isMaximized)
      {
        using (StringFormat sf = new StringFormat())
        {
          sf.Alignment = StringAlignment.Center;
          sf.LineAlignment = StringAlignment.Center;

          Rectangle textRect = new Rectangle(
            image != null ? image.Width : 0,
            0,
            this.Width - (image != null ? image.Width : 0),
            this.Height
          );

          e.Graphics.DrawString(Text, this.Font, Brushes.Black, textRect, sf);
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


      if (e.Button == MouseButtons.Left && !isMaximized)
      {
        base.OnMouseUp(e);
        if (ClientRectangle.Contains(e.Location))
        {
          OnClick(EventArgs.Empty);
          this.BackgroundImage = Resources.MainButtonPressed;
          isMaximized = true;
        }
        this.Invalidate();
      }
    }

    public void ResetButton()
    {
      if (isMaximized)
      {
        this.BackgroundImage = Resources.MainButtonUnpressed;
        isMaximized = false;
      }
    }

    public void ActivateButton()
    {
      if (!isMaximized)
      {
        this.BackgroundImage = Resources.MainButtonPressed;
        isMaximized = true;
        this.Invalidate();
      }
    }
  }
}
