using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.Properties;

namespace TibiaUtilities.CustomControls
{
  public class TibiaVScrollBar : UserControl
  {
    // Evento OnScroll cuando se mueve el thumb
    public event EventHandler ScrollChanged;
    public event EventHandler MouseWheel;

    private Timer holdScrollTimer = new Timer()
    {
      Interval = 100
    };

    private int waitPressTimer = 0;

    private bool thumbClicked = false;
    private int thumbTopLimit;
    private int thumbBottomLimit;
    private int thumbPosition = 0;
    private Rectangle thumbRectangle;

    private bool isUpButtonPressed = false;
    private bool isDownButtonPressed = false;

    private int buttonHeight = 14;
    private int thumbPartHeight = 14;
    private int borderSize = 1;

    private int thumbHeight = 50;
    private int minimum = 0;
    private int maximum = 100;
    private int value = 0;
    private int step = 10;

    #region Props
    [Browsable(true)]
    [Category("Scroll Bar Texture")]
    [Description("Textura de la parte superior del Thumb.")]
    public Image TopThumbTexture { get; set; } = Resources.TopThumbTexture;

    [Browsable(true)]
    [Category("Scroll Bar Texture")]
    [Description("Textura de la parte central del Thumb.")]
    public Image BodyThumbTexture { get; set; } = Resources.BodyThumbTexture;

    [Browsable(true)]
    [Category("Scroll Bar Texture")]
    [Description("Textura de la parte inferior del Thumb.")]
    public Image BottomThumbTexture { get; set; } = Resources.BottomThumbTexture;

    [Browsable(true)]
    [Category("Scroll Bar Texture")]
    [Description("Textura del botón superior.")]
    public Image UpButtonTexture { get; set; } = Resources.UpButtonTextureVSB;

    [Browsable(true)]
    [Category("Scroll Bar Texture")]
    [Description("Textura del botón inferior.")]
    public Image DownButtonTexture { get; set; } = Resources.DownButtonTextureVSB;

    [Browsable(true)]
    [Category("Scroll Bar Texture")]
    [Description("Textura del fondo del scrollbar.")]
    public Image TrackTexture { get; set; } = Resources.TrackTextureVSB;

    [Browsable(true)]
    [Category("Scroll Bar Prop")]
    [Description("Tamaño del thumb.")]
    public int ThumbHeight
    {
      get { return thumbHeight; }
      set
      {
        thumbHeight = value;
        if (thumbHeight < 2 * thumbPartHeight)
          thumbHeight = 2 * thumbPartHeight;

        // Redibujar inmediatamente en tiempo de diseño/ejecución
        thumbRectangle = new Rectangle(0, thumbTopLimit, this.Width, thumbHeight);
        this.Invalidate();
      }
    }

    [Browsable(true)]
    [Category("Scroll Bar Prop")]
    [Description("Tamaño minimo del thumb.")]
    public int MinumThumbHeight { get; set; }

    [Browsable(true)]
    [Category("Scroll Bar Prop")]
    [Description("Obtiene o establece el límite inferior de el valor del intervalo de desplazamiento.")]
    public int Minimum
    {
      get { return minimum; }
      set { minimum = value; }
    }

    [Browsable(true)]
    [Category("Scroll Bar Prop")]
    [Description("Obtiene o establece el límite superior de el valor del intervalo de desplazamiento.")]
    public int Maximum
    {
      get { return maximum; }
      set { maximum = value; }
    }

    [Browsable(true)]
    [Category("Scroll Bar Prop")]
    [Description("Obtiene o establece un valor numérico que representa la posición actual del cuadro de desplazamiento en el control de barra de desplazamiento.")]
    public int Value
    {
      get { return value; }
      set
      {
        if (value < minimum)
        {
          this.value = minimum;
        }
        else if (value > maximum)
        {
          this.value = maximum;
        }
        else
        {
          this.value = value;
        }

        UpdateThumbPositionFromValue();

        this.Invalidate();
      }
    }

    [Browsable(true)]
    [Category("Scroll Bar Prop")]
    [Description("Obtiene o establece un valor numérico que representa el movimiento del cuadro de dezplazamiento al precionar los botones.")]
    public int Step { get => step; set => step = value; }

    #endregion

    // Constructor
    public TibiaVScrollBar()
    {
      holdScrollTimer.Tick += HoldScrollTimer_Tick;

      this.Dock = DockStyle.Right;
      this.Width = 14;
      thumbTopLimit = buttonHeight;
      thumbBottomLimit = this.Height - buttonHeight;
      thumbRectangle = new Rectangle(0, thumbTopLimit, this.Width, ThumbHeight);

      // Optimización de dibujado
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.ResizeRedraw, true);
      this.UpdateStyles();
    }

    public void Mouse_Wheel(MouseEventArgs e)
    {
      if (e.Delta > 0)
      {
        ScrollUp();
      }
      else if (e.Delta < 0)
      {
        ScrollDown();
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      thumbBottomLimit = this.Height - buttonHeight;
      Invalidate();
    }

    // Manejador de eventos del mouse (clic)
    protected override void OnMouseDown(MouseEventArgs e)
    {
      base.OnMouseDown(e);

      // Verificar si se hizo clic en el botón superior
      if (new Rectangle(0, 0, this.Width, buttonHeight).Contains(e.Location))
      {
        isUpButtonPressed = true;
        ScrollUp();
        holdScrollTimer.Start();
        //Invalidate();
      }

      // Verificar si se hizo clic en el botón inferior
      else if (new Rectangle(0, this.Height - buttonHeight, this.Width, buttonHeight).Contains(e.Location))
      {
        isDownButtonPressed = true;
        ScrollDown();
        holdScrollTimer.Start();
        //Invalidate();
      }

      // Verificar si se hizo clic en el thumb
      if (thumbRectangle.Contains(e.Location))
      {
        thumbClicked = true;
        thumbPosition = e.Y - thumbRectangle.Y; // Guardamos el offset relativo al clic
      }
    }

    // Movimiento del thumb
    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);

      if (thumbClicked)
      {
        // Calcula la nueva posición del thumb
        int newThumbY = Math.Max(thumbTopLimit, Math.Min(thumbBottomLimit - thumbHeight, e.Y - thumbPosition));
        thumbRectangle.Y = newThumbY;

        // Actualiza el valor basado en la posición del thumb
        UpdateValueFromThumbPosition();

        OnScroll();  // Notificar el cambio en el scroll
        this.Invalidate(); // Redibujar el control
      }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      base.OnMouseUp(e);

      // Cuando se suelta el botón, restaurar el estado normal
      if (isUpButtonPressed || isDownButtonPressed)
      {
        isUpButtonPressed = false;
        isDownButtonPressed = false;
        Invalidate();
      }

      holdScrollTimer.Stop();
      waitPressTimer = 0;
      thumbClicked = false; // Finalizamos el arrastre del thumb
    }

    // Dibujar el thumb dividido en 3 partes
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      // Dibujar el fondo del track
      DrawTrack(e.Graphics);

      // Dibujar los botones del scroll (con efecto de presionado)
      DrawScrollButtons(e.Graphics);

      // Dibujar el TopThumb
      DrawThumbPart(e.Graphics, TopThumbTexture, thumbRectangle.X, thumbRectangle.Y, thumbPartHeight);

      // Dibujar el BodyThumb
      DrawThumbBody(e.Graphics, thumbRectangle.X, thumbRectangle.Y + thumbPartHeight, thumbRectangle.Height - 2 * thumbPartHeight);

      // Dibujar el BottomThumb
      DrawThumbPart(e.Graphics, BottomThumbTexture, thumbRectangle.X, thumbRectangle.Y + thumbRectangle.Height - thumbPartHeight, thumbPartHeight);
    }


    protected virtual void OnScroll()
    {
      ScrollChanged?.Invoke(this, EventArgs.Empty);
    }

    // Función para manejar el evento del timer
    private void HoldScrollTimer_Tick(object sender, EventArgs e)
    {
      if (waitPressTimer == 500)
      {
        if (isUpButtonPressed)
        {
          ScrollUp();
        }
        else if (isDownButtonPressed)
        {
          ScrollDown();
        }
      }
      else
        waitPressTimer += holdScrollTimer.Interval;
    }

    // Función para mover el thumb hacia arriba
    private void ScrollUp()
    {
      thumbRectangle.Y = Math.Max(thumbRectangle.Y - Step, thumbTopLimit);
      UpdateValueFromThumbPosition();
      this.Invalidate();
    }

    // Función para mover el thumb hacia abajo
    private void ScrollDown()
    {
      thumbRectangle.Y = Math.Min(thumbRectangle.Y + Step, thumbBottomLimit - thumbHeight);
      UpdateValueFromThumbPosition();
      this.Invalidate();
    }

    // Clave: DrawScrollButtons
    private void DrawScrollButtons(Graphics g)
    {
      // Dibujar el botón superior con efecto 3D
      Rectangle upButtonRect = new Rectangle(0, 0, this.Width, buttonHeight);
      DrawScrollButton3D(g, upButtonRect, isUpButtonPressed, UpButtonTexture);

      // Dibujar el botón inferior con efecto 3D
      Rectangle downButtonRect = new Rectangle(0, this.Height - buttonHeight, this.Width, buttonHeight);
      DrawScrollButton3D(g, downButtonRect, isDownButtonPressed, DownButtonTexture);
    }

    // Clave: DrawScrollButton3D
    private void DrawScrollButton3D(Graphics g, Rectangle buttonRect, bool isPressed, Image buttonTexture)
    {
      if (buttonTexture != null)
      {
        // Simula el efecto de "hundido" desplazando el contenido hacia abajo
        if (isPressed)
        {
          DrawShadow(g, buttonRect, borderSize);
          g.DrawImage(buttonTexture, buttonRect.X + borderSize, buttonRect.Y + borderSize); // Mover hacia abajo
        }
        else
        {
          g.DrawImage(buttonTexture, buttonRect);
        }
      }
      else
      {
        // Efecto 3D sin textura (color)
        if (isPressed)
        {
          DrawShadow(g, buttonRect, borderSize);
          ControlPaint.DrawBorder3D(g, buttonRect, Border3DStyle.Sunken);
          g.FillRectangle(Brushes.DarkGray, buttonRect.X + borderSize, buttonRect.Y + borderSize, buttonRect.Width, buttonRect.Height);
        }
        else
        {
          // Simular botón elevado
          ControlPaint.DrawBorder3D(g, buttonRect, Border3DStyle.Raised);
          g.FillRectangle(Brushes.LightGray, buttonRect);
        }
      }
    }

    // Clave: DrawShadow
    private void DrawShadow(Graphics g, Rectangle buttonRect, int offset)
    {
      // Dibujar borde en la parte superior e izquierda
      using (Brush shadowBrush = new SolidBrush(Color.FromArgb(255, Color.Black))) // Sombra semitransparente
      {
        // Dibujar borde superior
        g.FillRectangle(shadowBrush, buttonRect.Left, buttonRect.Top, buttonRect.Right, offset);

        // Dibujar borde izquierdo
        g.FillRectangle(shadowBrush, buttonRect.Left, buttonRect.Top, offset, buttonRect.Height);
      }
    }

    // Clave: DrawTrack
    private void DrawTrack(Graphics g)
    {
      if (TrackTexture != null)
      {
        g.DrawImage(TrackTexture, new Rectangle(0, buttonHeight, this.Width, this.Height - 2 * buttonHeight));
      }
      else
      {
        g.FillRectangle(Brushes.Gray, 0, buttonHeight, this.Width, this.Height - 2 * buttonHeight);
      }
    }

    // Clave: DrawThumbPart
    private void DrawThumbPart(Graphics g, Image texture, int x, int y, int height)
    {
      if (texture != null)
      {
        g.DrawImage(texture, new Rectangle(x, y, this.Width, height));
      }
      else
      {
        g.FillRectangle(Brushes.LightGray, x, y, this.Width, height);
      }
    }

    // Clave: DrawThumbBody
    private void DrawThumbBody(Graphics g, int x, int y, int height)
    {
      if (BodyThumbTexture != null)
      {
        TextureBrush bodyBrush = new TextureBrush(BodyThumbTexture, System.Drawing.Drawing2D.WrapMode.Tile);
        g.FillRectangle(bodyBrush, new Rectangle(x, y, this.Width, height));
      }
      else
      {
        g.FillRectangle(Brushes.Gray, x, y, this.Width, height);
      }
    }

    // Clave: UpdateValueFromThumbPosition
    private void UpdateValueFromThumbPosition()
    {
      int availableHeight = thumbBottomLimit - thumbTopLimit - thumbHeight;
      if (availableHeight > 0)
      {
        // Actualizar el valor en función de la posición actual del thumb
        value = minimum + (thumbRectangle.Y - thumbTopLimit) * (maximum - minimum) / availableHeight;
      }

      OnScroll();  // Notificar el cambio en el scroll
      this.Invalidate(); // Redibujar el control
    }

    // Clave: UpdateThumbPositionFromValue
    private void UpdateThumbPositionFromValue()
    {
      int availableHeight = thumbBottomLimit - thumbTopLimit - thumbHeight;
      if (availableHeight > 0)
      {
        // Calcular la nueva posición del thumb basada en el valor actual
        thumbRectangle.Y = thumbTopLimit + (value - minimum) * availableHeight / (maximum - minimum);
      }

      this.Invalidate(); // Redibujar el control
    }

    public void UpdateThumbSize(int totalElementsHeight)
    {
      int trackHeight = this.Height - (2 * buttonHeight);
      //int trackHeight = thumbBottomLimit - thumbTopLimit;
      var parent = this.Parent as Control;

      // Si el total de la altura de los elementos es menor o igual al panel visible, el thumb ocupa todo el track
      if (totalElementsHeight <= parent.Height)
      {
        thumbHeight = trackHeight;
      }
      else
      {
        // Calcula el tamaño proporcional del thumb basado en la relación entre el contenido y el tamaño visible
        thumbHeight = Math.Max(50, trackHeight * parent.Height / totalElementsHeight);
      }

      // Limitar el tamaño del thumb para que no sea mayor que el tamaño disponible en el track
      thumbHeight = Math.Min(thumbHeight, trackHeight);

      thumbRectangle.Y = thumbTopLimit;
      // Ajustar el rectángulo del thumb y redibujar
      thumbRectangle.Height = thumbHeight;
      this.Invalidate();
    }
  }
}
