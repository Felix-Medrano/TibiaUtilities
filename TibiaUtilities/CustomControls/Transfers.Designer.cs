using System.Drawing;
using System.Windows.Forms;

namespace TibiaUtilities.CustomControls
{
  partial class Transfers
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfers));
      this.receiverLabel = new System.Windows.Forms.Label();
      this.goldCoinPicture = new System.Windows.Forms.PictureBox();
      this.payerLabel = new System.Windows.Forms.Label();
      this.cantLabel = new System.Windows.Forms.Label();
      this.lblA = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.goldCoinPicture)).BeginInit();
      this.SuspendLayout();
      // 
      // receiverLabel
      // 
      this.receiverLabel.AutoSize = true;
      this.receiverLabel.BackColor = System.Drawing.Color.Transparent;
      this.receiverLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.receiverLabel.Location = new System.Drawing.Point(3, 23);
      this.receiverLabel.Name = "receiverLabel";
      this.receiverLabel.Size = new System.Drawing.Size(40, 15);
      this.receiverLabel.TabIndex = 0;
      this.receiverLabel.Text = "label1";
      // 
      // goldCoinPicture
      // 
      this.goldCoinPicture.BackColor = System.Drawing.Color.Transparent;
      this.goldCoinPicture.Image = ((System.Drawing.Image)(resources.GetObject("goldCoinPicture.Image")));
      this.goldCoinPicture.Location = new System.Drawing.Point(104, 16);
      this.goldCoinPicture.Name = "goldCoinPicture";
      this.goldCoinPicture.Size = new System.Drawing.Size(32, 32);
      this.goldCoinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.goldCoinPicture.TabIndex = 1;
      this.goldCoinPicture.TabStop = false;
      // 
      // payerLabel
      // 
      this.payerLabel.AutoSize = true;
      this.payerLabel.BackColor = System.Drawing.Color.Transparent;
      this.payerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.payerLabel.Location = new System.Drawing.Point(176, 24);
      this.payerLabel.Name = "payerLabel";
      this.payerLabel.Size = new System.Drawing.Size(40, 15);
      this.payerLabel.TabIndex = 2;
      this.payerLabel.Text = "label1";
      // 
      // cantLabel
      // 
      this.cantLabel.AutoSize = true;
      this.cantLabel.BackColor = System.Drawing.Color.Transparent;
      this.cantLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cantLabel.Location = new System.Drawing.Point(136, 24);
      this.cantLabel.Name = "cantLabel";
      this.cantLabel.Size = new System.Drawing.Size(38, 15);
      this.cantLabel.TabIndex = 3;
      this.cantLabel.Text = "label1";
      // 
      // lblA
      // 
      this.lblA.AutoSize = true;
      this.lblA.BackColor = System.Drawing.Color.Transparent;
      this.lblA.Location = new System.Drawing.Point(40, 24);
      this.lblA.Name = "lblA";
      this.lblA.Size = new System.Drawing.Size(61, 13);
      this.lblA.TabIndex = 4;
      this.lblA.Text = "le transfiere";
      // 
      // Transfers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.lblA);
      this.Controls.Add(this.receiverLabel);
      this.Controls.Add(this.goldCoinPicture);
      this.Controls.Add(this.cantLabel);
      this.Controls.Add(this.payerLabel);
      this.Name = "Transfers";
      this.Size = new System.Drawing.Size(219, 51);
      this.Click += new System.EventHandler(this.CopyToClipboard_Click);
      ((System.ComponentModel.ISupportInitialize)(this.goldCoinPicture)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label receiverLabel;
    private PictureBox goldCoinPicture;
    private Label payerLabel;
    private Label cantLabel;
    private Label lblA;
  }
}
