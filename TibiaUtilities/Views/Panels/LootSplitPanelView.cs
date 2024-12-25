using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using TibiaUtilities.Classes;
using TibiaUtilities.CustomControls;
using TibiaUtilities.CustomControls.BaseControl;
using TibiaUtilities.Interfaces;
using TibiaUtilities.Lib;
using TibiaUtilities.Models.LootSplit;
using TibiaUtilities.Properties;

namespace TibiaUtilities.Views.Panels
{
  public class LootSplitPanelView : Form, IPanelView
  {
    private TUPanel rightPanel;
    private TUPanel leftPanel;
    private TUPanel viewPanel;
    private TUControlButton resetBtn;
    private TUControlButton splitLootBtn;

    private readonly LootDisplayDataPool lootDisplayDataPool = new LootDisplayDataPool(10);
    private System.ComponentModel.IContainer components;
    private TUPanel topPanel;
    private TUPanel leftViewPort;
    private string keyPrefix;
    private TUPanel tibiaVScrollBarContainer;
    private TibiaVScrollBar tibiaVScrollBar;
    List<LootDisplayData> activeLootDisplayDatas = new List<LootDisplayData>();

    public Image ButtonImage { get; }

    public LootSplitPanelView()
    {
      InitializeComponent();
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      ButtonImage = Resources.Backpack;

      tibiaVScrollBar.ScrollChanged += TibiaScrollBar_ScrollChanged;
      leftViewPort.MouseWheel += ViewPort_MouseWheel;

      keyPrefix = TUHelper.ImageCache.GenerateKey($"{nameof(LootDisplayData)}TopPanel", topPanel.Width, topPanel.Height);
      if (TUHelper.ImageCache.GetImageFromCache(keyPrefix) != null)
      {
        topPanel.BackgroundImage = TUHelper.ImageCache.GetImageFromCache(keyPrefix);
      }
    }

    public Panel GetPanel()
    {
      return viewPanel;
    }

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LootSplitPanelView));
      this.viewPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.topPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.resetBtn = new TibiaUtilities.CustomControls.TUControlButton();
      this.splitLootBtn = new TibiaUtilities.CustomControls.TUControlButton();
      this.rightPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.leftPanel = new TibiaUtilities.CustomControls.TUPanel();
      this.leftViewPort = new TibiaUtilities.CustomControls.TUPanel();
      this.tibiaVScrollBarContainer = new TibiaUtilities.CustomControls.TUPanel();
      this.tibiaVScrollBar = new TibiaUtilities.CustomControls.TibiaVScrollBar();
      this.viewPanel.SuspendLayout();
      this.topPanel.SuspendLayout();
      this.leftPanel.SuspendLayout();
      this.leftViewPort.SuspendLayout();
      this.tibiaVScrollBarContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPanel
      // 
      this.viewPanel.BackColor = System.Drawing.Color.Transparent;
      this.viewPanel.Controls.Add(this.topPanel);
      this.viewPanel.Controls.Add(this.rightPanel);
      this.viewPanel.Controls.Add(this.leftPanel);
      this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPanel.Location = new System.Drawing.Point(0, 0);
      this.viewPanel.Name = "viewPanel";
      this.viewPanel.Size = new System.Drawing.Size(764, 475);
      this.viewPanel.TabIndex = 0;
      // 
      // topPanel
      // 
      this.topPanel.BackgroundImage = global::TibiaUtilities.Properties.Resources.TextureBackground;
      this.topPanel.Controls.Add(this.resetBtn);
      this.topPanel.Controls.Add(this.splitLootBtn);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.Size = new System.Drawing.Size(764, 60);
      this.topPanel.TabIndex = 3;
      // 
      // resetBtn
      // 
      this.resetBtn.BackgroundImage = global::TibiaUtilities.Properties.Resources.NormalButton;
      this.resetBtn.CornerHeight = 7;
      this.resetBtn.CornerWidth = 7;
      this.resetBtn.DrawText = true;
      this.resetBtn.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
      this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
      this.resetBtn.Image = null;
      this.resetBtn.Location = new System.Drawing.Point(147, 12);
      this.resetBtn.Name = "resetBtn";
      this.resetBtn.Size = new System.Drawing.Size(129, 25);
      this.resetBtn.SliceType = TibiaUtilities.Lib.TUFunctions.SliceType.ThreeSliceHorizontal;
      this.resetBtn.TabIndex = 5;
      this.resetBtn.Text = "Reset";
      this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
      // 
      // splitLootBtn
      // 
      this.splitLootBtn.BackgroundImage = global::TibiaUtilities.Properties.Resources.NormalButton;
      this.splitLootBtn.CornerHeight = 7;
      this.splitLootBtn.CornerWidth = 7;
      this.splitLootBtn.DrawText = true;
      this.splitLootBtn.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
      this.splitLootBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
      this.splitLootBtn.Image = null;
      this.splitLootBtn.Location = new System.Drawing.Point(12, 12);
      this.splitLootBtn.Name = "splitLootBtn";
      this.splitLootBtn.Size = new System.Drawing.Size(129, 25);
      this.splitLootBtn.SliceType = TibiaUtilities.Lib.TUFunctions.SliceType.ThreeSliceHorizontal;
      this.splitLootBtn.TabIndex = 4;
      this.splitLootBtn.Text = "Split Loot";
      this.splitLootBtn.Click += new System.EventHandler(this.SplitLootBtn_Click);
      // 
      // rightPanel
      // 
      this.rightPanel.BackgroundImage = global::TibiaUtilities.Properties.Resources.RightDataPanel;
      this.rightPanel.Location = new System.Drawing.Point(291, 65);
      this.rightPanel.Name = "rightPanel";
      this.rightPanel.Size = new System.Drawing.Size(473, 410);
      this.rightPanel.TabIndex = 1;
      // 
      // leftPanel
      // 
      this.leftPanel.BackgroundImage = global::TibiaUtilities.Properties.Resources.LeftDataPanel;
      this.leftPanel.Controls.Add(this.leftViewPort);
      this.leftPanel.Location = new System.Drawing.Point(0, 65);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Padding = new System.Windows.Forms.Padding(5);
      this.leftPanel.Size = new System.Drawing.Size(286, 410);
      this.leftPanel.TabIndex = 2;
      // 
      // leftViewPort
      // 
      this.leftViewPort.Controls.Add(this.tibiaVScrollBarContainer);
      this.leftViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftViewPort.Location = new System.Drawing.Point(5, 5);
      this.leftViewPort.Name = "leftViewPort";
      this.leftViewPort.Size = new System.Drawing.Size(276, 400);
      this.leftViewPort.TabIndex = 0;
      // 
      // tibiaVScrollBarContainer
      // 
      this.tibiaVScrollBarContainer.Controls.Add(this.tibiaVScrollBar);
      this.tibiaVScrollBarContainer.Dock = System.Windows.Forms.DockStyle.Right;
      this.tibiaVScrollBarContainer.Location = new System.Drawing.Point(262, 0);
      this.tibiaVScrollBarContainer.Name = "tibiaVScrollBarContainer";
      this.tibiaVScrollBarContainer.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
      this.tibiaVScrollBarContainer.Size = new System.Drawing.Size(14, 400);
      this.tibiaVScrollBarContainer.TabIndex = 0;
      // 
      // tibiaVScrollBar
      // 
      this.tibiaVScrollBar.BodyThumbTexture = ((System.Drawing.Image)(resources.GetObject("tibiaVScrollBar.BodyThumbTexture")));
      this.tibiaVScrollBar.BottomThumbTexture = ((System.Drawing.Image)(resources.GetObject("tibiaVScrollBar.BottomThumbTexture")));
      this.tibiaVScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
      this.tibiaVScrollBar.DownButtonTexture = ((System.Drawing.Image)(resources.GetObject("tibiaVScrollBar.DownButtonTexture")));
      this.tibiaVScrollBar.Location = new System.Drawing.Point(-1, 1);
      this.tibiaVScrollBar.Maximum = 100;
      this.tibiaVScrollBar.Minimum = 0;
      this.tibiaVScrollBar.MinumThumbHeight = 0;
      this.tibiaVScrollBar.Name = "tibiaVScrollBar";
      this.tibiaVScrollBar.Size = new System.Drawing.Size(14, 398);
      this.tibiaVScrollBar.Step = 5;
      this.tibiaVScrollBar.TabIndex = 0;
      this.tibiaVScrollBar.ThumbHeight = 50;
      this.tibiaVScrollBar.TopThumbTexture = ((System.Drawing.Image)(resources.GetObject("tibiaVScrollBar.TopThumbTexture")));
      this.tibiaVScrollBar.TrackTexture = ((System.Drawing.Image)(resources.GetObject("tibiaVScrollBar.TrackTexture")));
      this.tibiaVScrollBar.UpButtonTexture = ((System.Drawing.Image)(resources.GetObject("tibiaVScrollBar.UpButtonTexture")));
      this.tibiaVScrollBar.Value = 0;
      // 
      // LootSplitPanelView
      // 
      this.ClientSize = new System.Drawing.Size(764, 475);
      this.Controls.Add(this.viewPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "LootSplitPanelView";
      this.viewPanel.ResumeLayout(false);
      this.topPanel.ResumeLayout(false);
      this.leftPanel.ResumeLayout(false);
      this.leftViewPort.ResumeLayout(false);
      this.tibiaVScrollBarContainer.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    private void SplitLootBtn_Click(object sender, System.EventArgs e)
    {
      string clipboardText = Clipboard.GetText();

      // Parsear la información de la sesión
      SessionInfo sessionInfo = ParseClipboardData(clipboardText);
      if (sessionInfo == null)
      {
        return; // Si no se pudo parsear la información, salimos de la función
      }

      // Regex para extraer la información de cada jugador
      //string pattern = @"(?<name>[^\n]+)\s+Loot:\s(?<loot>[\d,]+)\s+Supplies:\s(?<supplies>[\d,]+)\s+Balance:\s(?<balance>[\-\d,]+)";

      //Regex para extraer la informacion completa de cada jugador
      string pattern = @"(?<name>[^\n]+)\s+Loot:\s(?<loot>[\d,]+)\s+Supplies:\s(?<supplies>[\d,]+)\s+Balance:\s(?<balance>[\-\d,]+)\s+Damage:\s(?<damage>[\d,]+)\s+Healing:\s(?<healing>[\d,]+)";
      Regex regex = new Regex(pattern);

      // Verificar si el texto coincide con el patrón
      if (!regex.IsMatch(clipboardText))
      {
        MessageBox.Show("No se encontró información de la Hunt en el Portapapeles.\n" +
            "Asegúrate de copiar la Sesión desde el cliente.\n\n" +
            "- Abre \"Party Hunt\"\n" +
            "- Presiona el botón de menú\n" +
            "- Selecciona \"Copy to clipboard\"", "Sin Info de Hunt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Lista de jugadores
      List<Player> players = new List<Player>();

      // Extraer jugadores y sus datos
      foreach (Match match in regex.Matches(clipboardText))
      {
        if (match.Groups["name"].Value.Trim() != "Loot Type: Market")
        {
          string name = match.Groups["name"].Value.Trim();
          name = name.Replace("(Leader)", "").Trim();  // Elimina "(Leader)" y posibles espacios en blanco
          int loot = int.Parse(match.Groups["loot"].Value.Replace(",", ""));
          int supplies = int.Parse(match.Groups["supplies"].Value.Replace(",", ""));
          int balance = int.Parse(match.Groups["balance"].Value.Replace(",", ""));
          int damage = int.Parse(match.Groups["damage"].Value.Replace(",", ""));
          int healing = int.Parse(match.Groups["healing"].Value.Replace(",", ""));

          // Crear jugador y agregar a la lista
          Player player = new Player(name, loot, supplies, damage, healing);
          players.Add(player);
        }
      }

      // Actualizar la etiqueta del panel izquierdo con la información de la sesión y los jugadores
      UpdateLeftPanelLabel(sessionInfo, players);

      foreach (Control control in leftPanel.Controls)
      {
        if (control is LootDisplayData data)
        {
          data.Visible = true;
          data.CalculateAndSetHeight();
        }
      }

      // Llamar al LootSplitter con los datos obtenidos
      LootSplitter lootSplitter = new LootSplitter(players);
      var transferList = lootSplitter.SplitLoot();
      Point location = new Point(15, 15);

      foreach (var transfer in transferList)
      {
        transfer.Location = location;
        rightPanel.Controls.Add(transfer);
        location.Y += transfer.Height;
      }

      // Calcular el profit total y por jugador
      int totalProfit = sessionInfo.BalanceAmount;
      int profitPerPlayer = totalProfit / players.Count;

      // Crear y agregar el label de Total Profit
      Label totalProfitLabel = new Label
      {
        Text = $"Total Profit\n{profitPerPlayer:N0} each",
        Font = new Font("Constantia", 12, FontStyle.Bold),
        ForeColor = Color.Gold,
        TextAlign = ContentAlignment.MiddleCenter,
        AutoSize = false,
        Size = new Size(200, 50),
        Location = new Point(rightPanel.Width / 2 - 100, location.Y + 10)
      };

      rightPanel.Controls.Add(totalProfitLabel);

    }

    private SessionInfo ParseClipboardData(string clipboardText)
    {
      // Regex para extraer la información de la sesión
      string sessionPattern = @"Session data: From (.*) to (.*)\s*Session: (.*)\s*Loot Type: (.*)\s*Loot: ([\d,]+)\s*Supplies: ([\d,]+)\s*Balance: ([\-\d,]+)";
      Regex sessionRegex = new Regex(sessionPattern);

      Match sessionMatch = sessionRegex.Match(clipboardText);
      if (!sessionMatch.Success)
      {
        MessageBox.Show("No se encontró información de sesión válida en el portapapeles.\n" +
            "Asegúrate de copiar la Sesión desde el cliente.\n\n" +
            "- Abre \"Party Hunt\"\n" +
            "- Presiona el botón de menú\n" +
            "- Selecciona \"Copy to clipboard\"", "Sin Info de Hunt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return null;
      }

      DateTime sessionStart = DateTime.Parse(sessionMatch.Groups[1].Value);
      DateTime sessionEnd = DateTime.Parse(sessionMatch.Groups[2].Value);
      TimeSpan sessionDuration = TimeSpan.Parse(sessionMatch.Groups[3].Value.Replace("h", ""));
      string lootType = sessionMatch.Groups[4].Value;
      int lootAmount = int.Parse(sessionMatch.Groups[5].Value.Replace(",", ""));
      int suppliesAmount = int.Parse(sessionMatch.Groups[6].Value.Replace(",", ""));
      int balanceAmount = int.Parse(sessionMatch.Groups[7].Value.Replace(",", ""));

      return new SessionInfo(sessionStart, sessionEnd, sessionDuration, lootType, lootAmount, suppliesAmount, balanceAmount);
    }

    private void UpdateLeftPanelLabel(SessionInfo sessionInfo, List<Player> players)
    {
      Point nextLocation = new Point(1, 1);

      ResetPanels();

      foreach (var player in players)
      {
        LootDisplayData lootDisplayData = lootDisplayDataPool.Get();
        lootDisplayData.NameText = player.Name;
        lootDisplayData.LootValue = player.Loot;
        lootDisplayData.SuppliesValue = player.Supplies;
        lootDisplayData.BalanceValue = player.Balance;
        lootDisplayData.DamageValue = player.Damage;
        lootDisplayData.HealingValue = player.Healing;
        lootDisplayData.Location = nextLocation;
        lootDisplayData.IsMinizable = false;
        lootDisplayData.Height = TUConsts.LOOT_DISPLAY_DATA_HEIGHT;
        lootDisplayData.Width = TUConsts.LOOT_DISPLAY_DATA_WIDTH;
        //lootDisplayData.PanelClicked += (s, e) => this.Refresh();

        lootDisplayData.ApplyData();

        nextLocation.Y += lootDisplayData.Height + 2;
        activeLootDisplayDatas.Add(lootDisplayData);
        leftViewPort.Controls.Add(lootDisplayData);
      }

      keyPrefix = TUHelper.ImageCache.GenerateKey($"{nameof(LootDisplayData)}LeftViewPort", leftViewPort.Width, leftViewPort.Height);
      if (TUHelper.ImageCache.GetImageFromCache(keyPrefix) != null)
      {
        leftViewPort.BackgroundImage = TUHelper.ImageCache.GetImageFromCache(keyPrefix);
      }

      UpdateScrollBarMaximum();
    }

    private void resetBtn_Click(object sender, EventArgs e)
    {
      ResetPanels();
    }

    private void ResetPanels()
    {
      var itemsToRemove = new List<LootDisplayData>();

      foreach (var data in activeLootDisplayDatas)
      {
        lootDisplayDataPool.Return(data);
        itemsToRemove.Add(data);
      }

      foreach (var item in itemsToRemove)
      {
        activeLootDisplayDatas.Remove(item);
      }

      leftViewPort.Controls.Clear();
      rightPanel.Controls.Clear();

      leftViewPort.Controls.Add(tibiaVScrollBarContainer);
      leftViewPort.BackgroundImage = null;
    }

    private void ViewPort_MouseWheel(object sender, MouseEventArgs e)
    {
      tibiaVScrollBar.Mouse_Wheel(e);
    }

    private void TibiaScrollBar_ScrollChanged(object sender, EventArgs e)
    {
      int maxScroll = GetTotalElementsHeight(leftViewPort.Controls) - leftViewPort.Height;
      int scrollOffset = (int)((float)tibiaVScrollBar.Value / tibiaVScrollBar.Maximum * maxScroll);

      RepositionControls(scrollOffset);

      leftViewPort.PerformLayout();
      //leftViewPort.Invalidate();
      leftViewPort.Update();
    }

    private int GetTotalElementsHeight(Control.ControlCollection controls)
    {
      int totalElementsHeight = 0;
      foreach (Control control in controls)
      {
        if (control is DisplayDataPanel)
        {
          totalElementsHeight += control.Height;
        }
      }
      return totalElementsHeight;
    }

    private void UpdateScrollBarMaximum()
    {
      int totalElementsHeight = GetTotalElementsHeight(leftViewPort.Controls);
      tibiaVScrollBar.Maximum = totalElementsHeight - leftViewPort.Height;
      tibiaVScrollBar.UpdateThumbSize(totalElementsHeight);
    }

    private void RepositionControls(int scrollOffset)
    {
      Console.WriteLine($"ScrollOffset: {scrollOffset}");
      Point nextTitleLocation = new Point(1, -scrollOffset); // Comienza desde el desplazamiento negativo

      foreach (Control control in leftViewPort.Controls)
      {
        if (control is DisplayDataPanel displayData)
        {
          // Colocar el HouseTitle en la nueva posición basada en el desplazamiento
          displayData.Location = nextTitleLocation;

          // Actualizar la siguiente ubicación según la altura actual del HouseTitle
          nextTitleLocation = new Point(0, displayData.Bottom);
        }
      }
    }
  }
}
