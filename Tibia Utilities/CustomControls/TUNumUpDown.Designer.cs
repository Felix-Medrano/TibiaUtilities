namespace Tibia_Utilities.CustomControls
{
  partial class TUNumUpDown
  {
    /// <summary> 
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de componentes

    /// <summary> 
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.num = new Tibia_Utilities.CustomControls.TUTextBox();
      this.tuPanel1 = new Tibia_Utilities.CustomControls.TUPanel();
      this.downBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.upBtn = new Tibia_Utilities.CustomControls.TUSliceButton();
      this.tuPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // num
      // 
      this.num.Dock = System.Windows.Forms.DockStyle.Fill;
      this.num.Location = new System.Drawing.Point(0, 0);
      this.num.Name = "num";
      this.num.Size = new System.Drawing.Size(130, 20);
      this.num.TabIndex = 1;
      this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.num.Type = Tibia_Utilities.CustomControls.TUTextBox.TextBoxType.Normal;
      // 
      // tuPanel1
      // 
      this.tuPanel1.Controls.Add(this.downBtn);
      this.tuPanel1.Controls.Add(this.upBtn);
      this.tuPanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.tuPanel1.Location = new System.Drawing.Point(130, 0);
      this.tuPanel1.MaximumSize = new System.Drawing.Size(20, 20);
      this.tuPanel1.MinimumSize = new System.Drawing.Size(20, 20);
      this.tuPanel1.Name = "tuPanel1";
      this.tuPanel1.Size = new System.Drawing.Size(20, 20);
      this.tuPanel1.TabIndex = 0;
      // 
      // downBtn
      // 
      this.downBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.downBtn.Location = new System.Drawing.Point(0, 10);
      this.downBtn.Name = "downBtn";
      this.downBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.MainButtonUnpressed;
      this.downBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.MainButtonPressed;
      this.downBtn.Size = new System.Drawing.Size(20, 10);
      this.downBtn.TabIndex = 1;
      this.downBtn.Text = "▼";
      this.downBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.MainButtonUnpressed;
      this.downBtn.UseVisualStyleBackColor = true;
      this.downBtn.Click += new System.EventHandler(this.DownBtn_Click);
      // 
      // upBtn
      // 
      this.upBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.upBtn.Location = new System.Drawing.Point(0, 0);
      this.upBtn.Name = "upBtn";
      this.upBtn.OriginalImage = global::Tibia_Utilities.Properties.Resources.MainButtonUnpressed;
      this.upBtn.PressedImage = global::Tibia_Utilities.Properties.Resources.MainButtonPressed;
      this.upBtn.Size = new System.Drawing.Size(20, 10);
      this.upBtn.TabIndex = 0;
      this.upBtn.Text = "▲";
      this.upBtn.UnpressedImage = global::Tibia_Utilities.Properties.Resources.MainButtonUnpressed;
      this.upBtn.UseVisualStyleBackColor = true;
      this.upBtn.Click += new System.EventHandler(this.UpBtn_Click);
      // 
      // TUNumUpDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.num);
      this.Controls.Add(this.tuPanel1);
      this.MinimumSize = new System.Drawing.Size(75, 20);
      this.Name = "TUNumUpDown";
      this.Size = new System.Drawing.Size(150, 20);
      this.tuPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private TUPanel tuPanel1;
    private TUSliceButton upBtn;
    private TUSliceButton downBtn;
    private TUTextBox num;
  }
}
