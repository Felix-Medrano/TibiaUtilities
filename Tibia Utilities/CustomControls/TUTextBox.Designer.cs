namespace Tibia_Utilities.CustomControls
{
  partial class TUTextBox
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
      this.viewPort = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.text = new System.Windows.Forms.TextBox();
      this.viewPort.SuspendLayout();
      this.SuspendLayout();
      // 
      // viewPort
      // 
      this.viewPort.Controls.Add(this.text);
      this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.viewPort.EdgeHeight = 5;
      this.viewPort.EdgeWidth = 5;
      this.viewPort.Location = new System.Drawing.Point(0, 0);
      this.viewPort.Margin = new System.Windows.Forms.Padding(0);
      this.viewPort.Name = "viewPort";
      this.viewPort.OriginalImage = global::Tibia_Utilities.Properties.Resources.TextBoxBackGround;
      this.viewPort.Padding = new System.Windows.Forms.Padding(3);
      this.viewPort.Size = new System.Drawing.Size(130, 30);
      this.viewPort.TabIndex = 0;
      // 
      // text
      // 
      this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
      this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.text.Dock = System.Windows.Forms.DockStyle.Fill;
      this.text.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
      this.text.Location = new System.Drawing.Point(3, 3);
      this.text.Margin = new System.Windows.Forms.Padding(0);
      this.text.Name = "text";
      this.text.Size = new System.Drawing.Size(124, 15);
      this.text.TabIndex = 0;
      this.text.WordWrap = false;
      // 
      // TUTextBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.viewPort);
      this.Name = "TUTextBox";
      this.Size = new System.Drawing.Size(130, 30);
      this.viewPort.ResumeLayout(false);
      this.viewPort.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private TUSlicePanel viewPort;
    private System.Windows.Forms.TextBox text;
  }
}
