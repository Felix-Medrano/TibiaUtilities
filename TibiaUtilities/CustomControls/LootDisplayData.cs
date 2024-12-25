using System;
using System.Drawing;
using System.Windows.Forms;

using TibiaUtilities.CustomControls.BaseControl;
using TibiaUtilities.Lib;

namespace TibiaUtilities.CustomControls
{
  public class LootDisplayData : DisplayDataPanel
  {
    public event EventHandler PanelClicked;
    private Label loot;
    private Label supplies;
    private Label balance;
    private Label damage;
    private Label healing;
    private Label lootAmount;
    private Label suppliesAmount;
    private Label balanceAmount;
    private Label damageAmount;
    private Label healingAmount;

    private bool isMaximized = false;
    private int totalHeight;

    public string NameText { get; set; }
    public int LootValue { get; set; }
    public int SuppliesValue { get; set; }
    public int BalanceValue { get; set; }
    public int DamageValue { get; set; }
    public int HealingValue { get; set; }

    public LootDisplayData()
    {
      InitializeComponent();
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      this.Height = 129;
      this.Width = 265;
    }

    private void InitializeComponent()
    {
      this.healingAmount = new System.Windows.Forms.Label();
      this.damageAmount = new System.Windows.Forms.Label();
      this.balanceAmount = new System.Windows.Forms.Label();
      this.suppliesAmount = new System.Windows.Forms.Label();
      this.lootAmount = new System.Windows.Forms.Label();
      this.healing = new System.Windows.Forms.Label();
      this.damage = new System.Windows.Forms.Label();
      this.balance = new System.Windows.Forms.Label();
      this.supplies = new System.Windows.Forms.Label();
      this.loot = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // healingAmount
      // 
      this.healingAmount.AutoSize = true;
      this.healingAmount.BackColor = System.Drawing.Color.Transparent;
      this.healingAmount.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.healingAmount.Location = new System.Drawing.Point(68, 82);
      this.healingAmount.Name = "healingAmount";
      this.healingAmount.Size = new System.Drawing.Size(88, 17);
      this.healingAmount.TabIndex = 10;
      this.healingAmount.Text = "999,999,999";
      // 
      // damageAmount
      // 
      this.damageAmount.AutoSize = true;
      this.damageAmount.BackColor = System.Drawing.Color.Transparent;
      this.damageAmount.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.damageAmount.Location = new System.Drawing.Point(70, 67);
      this.damageAmount.Name = "damageAmount";
      this.damageAmount.Size = new System.Drawing.Size(88, 17);
      this.damageAmount.TabIndex = 9;
      this.damageAmount.Text = "999,999,999";
      // 
      // balanceAmount
      // 
      this.balanceAmount.AutoSize = true;
      this.balanceAmount.BackColor = System.Drawing.Color.Transparent;
      this.balanceAmount.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.balanceAmount.Location = new System.Drawing.Point(68, 52);
      this.balanceAmount.Name = "balanceAmount";
      this.balanceAmount.Size = new System.Drawing.Size(88, 17);
      this.balanceAmount.TabIndex = 8;
      this.balanceAmount.Text = "999,999,999";
      // 
      // suppliesAmount
      // 
      this.suppliesAmount.AutoSize = true;
      this.suppliesAmount.BackColor = System.Drawing.Color.Transparent;
      this.suppliesAmount.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.suppliesAmount.Location = new System.Drawing.Point(68, 37);
      this.suppliesAmount.Name = "suppliesAmount";
      this.suppliesAmount.Size = new System.Drawing.Size(88, 17);
      this.suppliesAmount.TabIndex = 7;
      this.suppliesAmount.Text = "999,999,999";
      // 
      // lootAmount
      // 
      this.lootAmount.AutoSize = true;
      this.lootAmount.BackColor = System.Drawing.Color.Transparent;
      this.lootAmount.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lootAmount.Location = new System.Drawing.Point(42, 22);
      this.lootAmount.Name = "lootAmount";
      this.lootAmount.Size = new System.Drawing.Size(88, 17);
      this.lootAmount.TabIndex = 6;
      this.lootAmount.Text = "999,999,999";
      // 
      // healing
      // 
      this.healing.AutoSize = true;
      this.healing.BackColor = System.Drawing.Color.Transparent;
      this.healing.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.healing.Location = new System.Drawing.Point(3, 82);
      this.healing.Name = "healing";
      this.healing.Size = new System.Drawing.Size(67, 17);
      this.healing.TabIndex = 5;
      this.healing.Text = "Healing:";
      // 
      // damage
      // 
      this.damage.AutoSize = true;
      this.damage.BackColor = System.Drawing.Color.Transparent;
      this.damage.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.damage.Location = new System.Drawing.Point(3, 67);
      this.damage.Name = "damage";
      this.damage.Size = new System.Drawing.Size(68, 17);
      this.damage.TabIndex = 4;
      this.damage.Text = "Damage:";
      // 
      // balance
      // 
      this.balance.AutoSize = true;
      this.balance.BackColor = System.Drawing.Color.Transparent;
      this.balance.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.balance.Location = new System.Drawing.Point(3, 52);
      this.balance.Name = "balance";
      this.balance.Size = new System.Drawing.Size(66, 17);
      this.balance.TabIndex = 3;
      this.balance.Text = "Balance:";
      // 
      // supplies
      // 
      this.supplies.AutoSize = true;
      this.supplies.BackColor = System.Drawing.Color.Transparent;
      this.supplies.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.supplies.Location = new System.Drawing.Point(3, 37);
      this.supplies.Name = "supplies";
      this.supplies.Size = new System.Drawing.Size(66, 17);
      this.supplies.TabIndex = 2;
      this.supplies.Text = "Supplies";
      // 
      // loot
      // 
      this.loot.AutoSize = true;
      this.loot.BackColor = System.Drawing.Color.Transparent;
      this.loot.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loot.Location = new System.Drawing.Point(3, 22);
      this.loot.Name = "loot";
      this.loot.Size = new System.Drawing.Size(41, 17);
      this.loot.TabIndex = 1;
      this.loot.Text = "Loot:";
      // 
      // LootDisplayData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.healingAmount);
      this.Controls.Add(this.damageAmount);
      this.Controls.Add(this.balanceAmount);
      this.Controls.Add(this.suppliesAmount);
      this.Controls.Add(this.lootAmount);
      this.Controls.Add(this.healing);
      this.Controls.Add(this.damage);
      this.Controls.Add(this.balance);
      this.Controls.Add(this.supplies);
      this.Controls.Add(this.loot);
      this.Name = "LootDisplayData";
      this.Size = new System.Drawing.Size(265, 110);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private Color BalanceTextColor()
    {
      Color color = TUFonts.Description.TextColor;
      if (BalanceValue > 0) color = Color.Green;
      if (BalanceValue < 0) color = Color.Red;

      return color;
    }

    public void CalculateAndSetHeight()
    {
      int spacing = 5;
      totalHeight = TopPanel.Height;

      void AdjustAndRelocate(Control label, Control amount)
      {
        label.Top = totalHeight;
        amount.Top = totalHeight;
        int maxHeight = Math.Max(label.Height, amount.Height);
        totalHeight += maxHeight + spacing;
      }

      AdjustAndRelocate(loot, lootAmount);
      AdjustAndRelocate(supplies, suppliesAmount);
      AdjustAndRelocate(balance, balanceAmount);
      AdjustAndRelocate(damage, damageAmount);
      AdjustAndRelocate(healing, healingAmount);
    }

    public void ApplyData()
    {
      SetTitle(NameText);
      lootAmount.Text = LootValue.ToString("N0");
      suppliesAmount.Text = SuppliesValue.ToString("N0");
      balanceAmount.Text = BalanceValue.ToString("N0");
      balanceAmount.ForeColor = BalanceTextColor();
      damageAmount.Text = DamageValue.ToString("N0");
      healingAmount.Text = HealingValue.ToString("N0");

      loot.ForeColor =
      supplies.ForeColor =
      balance.ForeColor =
      damage.ForeColor =
      healing.ForeColor = TUFonts.Title.TextColor;

      lootAmount.ForeColor =
      suppliesAmount.ForeColor =
      damageAmount.ForeColor =
      healingAmount.ForeColor = TUFonts.Description.TextColor;

      var keyPrefix = TUHelper.ImageCache.GenerateKey(nameof(LootDisplayData), Width, Height);
      if (TUHelper.ImageCache.GetImageFromCache(keyPrefix) != null)
      {
        this.BackgroundImage = TUHelper.ImageCache.GetImageFromCache(keyPrefix);
      }

      CalculateAndSetHeight();
    }

    public void Reset()
    {
      NameText = string.Empty;
      LootValue = 0;
      SuppliesValue = 0;
      BalanceValue = 0;
      DamageValue = 0;
      HealingValue = 0;
      Location = Point.Empty;
    }
  }
}
