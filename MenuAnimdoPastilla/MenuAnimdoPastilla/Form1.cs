using Svg;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace MenuAnimdoPastilla
{
  public partial class Form1 : Form
  {
    [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    // SVG ICONOS COMO STRINGS
    private string HomeIcon => @"
<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill='white'>
  <path d='M3 9.5L12 3l9 6.5V20a1 1 0 01-1 1h-5v-6H9v6H4a1 1 0 01-1-1V9.5z'/>
</svg>";

    private string UserIcon => @"
<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill='white'>
  <path d='M12 2a5 5 0 110 10 5 5 0 010-10zm0 12c-4.418 0-8 2.015-8 4.5V21h16v-2.5c0-2.485-3.582-4.5-8-4.5z'/>
</svg>";

    private string CameraIcon => @"
<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill='white'>
  <path d='M4 7h3l2-3h6l2 3h3a1 1 0 011 1v11a1 1 0 01-1 1H4a1 1 0 01-1-1V8a1 1 0 011-1zm8 2a5 5 0 100 10 5 5 0 000-10z'/>
</svg>";

    private string GearIcon => @"
<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill='white'>
  <path d='M19.14 12.936a7.976 7.976 0 000-1.872l2.036-1.585a.5.5 0 00.121-.637l-1.928-3.34a.5.5 0 00-.607-.222l-2.396.96a7.977 7.977 0 00-1.623-.94L14 2.5a.5.5 0 00-.5-.5h-3a.5.5 0 00-.5.5l-.347 2.8a7.977 7.977 0 00-1.623.94l-2.396-.96a.5.5 0 00-.607.222L2.703 8.842a.5.5 0 00.121.637l2.036 1.585a7.976 7.976 0 000 1.872l-2.036 1.585a.5.5 0 00-.121.637l1.928 3.34a.5.5 0 00.607.222l2.396-.96a7.977 7.977 0 001.623.94L10 21.5a.5.5 0 00.5.5h3a.5.5 0 00.5-.5l.347-2.8a7.977 7.977 0 001.623-.94l2.396.96a.5.5 0 00.607-.222l1.928-3.34a.5.5 0 00-.121-.637l-2.036-1.585zM12 15a3 3 0 110-6 3 3 0 010 6z'/>
</svg>";

    private Panel navigationPanel;
    private Panel selector;
    private Timer animationTimer;
    private Point targetPosition;

    private Point selectorPosition;
    private Point selectorTarget;
    private int selectorSize = 70;

    public Form1()
    {
      InitializeComponent();
      InitializeNavigationMenu();
    }

    private void InitializeNavigationMenu()
    {
      BackColor = Color.FromArgb(40, 44, 52);
      Size = new Size(500, 200);

      // Panel de navegación
      navigationPanel = new Panel
      {
        Size = new Size(420, 70),
        Location = new Point(40, 40),
        BackColor = Color.FromArgb(32, 156, 255)
      };
      navigationPanel.Region = Region.FromHrgn(
          CreateRoundRectRgn(0, 0, navigationPanel.Width, navigationPanel.Height, 20, 20));
      Controls.Add(navigationPanel);

      // Selector circular
      selector = new Panel
      {
        Size = new Size(70, 70),
        BackColor = Color.White
      };
      selector.Region = Region.FromHrgn(CreateRoundRectRgn(10, 10, 60, 60, 100, 100));
      navigationPanel.Controls.Add(selector);

      // Lista de iconos SVG
      string[] svgIcons = { HomeIcon, UserIcon, CameraIcon, GearIcon };
      List<Button> buttons = new List<Button>();

      // Crear botones
      for (int i = 0; i < svgIcons.Length; i++)
      {
        Button btn = new Button
        {
          Size = new Size(70, 70),
          Location = new Point(i * 70, 0),
          FlatStyle = FlatStyle.Flat,
          BackColor = Color.Transparent,
          Image = SvgToImage(svgIcons[i], 32, 32, new MemoryStream(System.Text.Encoding.UTF8.GetBytes(svgIcons[i]))),
          Tag = i
        };
        btn.FlatAppearance.BorderSize = 0;
        btn.Click += NavButton_Click;
        navigationPanel.Controls.Add(btn);
        buttons.Add(btn);
      }

      // Inicializar selector
      selector.BringToFront();
      targetPosition = buttons[0].Location;

      // Timer para animación
      animationTimer = new Timer { Interval = 15 };
      animationTimer.Tick += (s, e) => AnimateSelector();
      animationTimer.Start();
    }

    private void NavButton_Click(object sender, EventArgs e)
    {
      if (sender is Button btn)
      {
        targetPosition = btn.Location;
      }
    }

    private void AnimateSelector()
    {
      int speed = 5;
      int dx = targetPosition.X - selector.Location.X;

      if (Math.Abs(dx) > 1)
      {
        int step = dx / speed;
        selector.Left += step != 0 ? step : Math.Sign(dx);
        navigationPanel.Invalidate(); // repinta
        UpdateNavigationRegion();     // actualiza el recorte
      }
    }

    // Utilidades

    private Image SvgToImage(string svgContent, int width, int height, MemoryStream svgStream)
    {
      var svgDoc = SvgDocument.Open<SvgDocument>(svgStream);
      svgDoc.Width = width;
      svgDoc.Height = height;
      return svgDoc.Draw();
    }

    private void UpdateNavigationRegion()
    {
      int notchRadius = 35; // Radio de la "U"
      int notchX = selectorPosition.X + (selectorSize / 2) - notchRadius;

      // Rectángulo base con bordes redondeados
      GraphicsPath path = new GraphicsPath();
      path.AddArc(0, 0, 20, 20, 180, 90); // esquina superior izquierda
      path.AddArc(navigationPanel.Width - 20, 0, 20, 20, 270, 90); // esquina superior derecha
      path.AddArc(navigationPanel.Width - 20, navigationPanel.Height - 20, 20, 20, 0, 90); // abajo derecha
      path.AddArc(0, navigationPanel.Height - 20, 20, 20, 90, 90); // abajo izquierda
      path.CloseFigure();

      // Recorte (media luna)
      GraphicsPath notch = new GraphicsPath();
      notch.AddEllipse(notchX, -notchRadius / 2, notchRadius * 2, notchRadius);
      Region region = new Region(path);
      region.Exclude(notch);

      navigationPanel.Region = region;
    }
  }
}
