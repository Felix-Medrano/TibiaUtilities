namespace Tibia_Utilities.CustomControls
{
  partial class TibiaVScrollBar
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
      this.track = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.thumb = new Tibia_Utilities.CustomControls.TUSlicePanel();
      this.up = new Tibia_Utilities.CustomControls.TUCtrlButton();
      this.down = new Tibia_Utilities.CustomControls.TUCtrlButton();
      this.track.SuspendLayout();
      this.SuspendLayout();
      // 
      // track
      // 
      this.track.Controls.Add(this.down);
      this.track.Controls.Add(this.up);
      this.track.Controls.Add(this.thumb);
      this.track.EdgeHeight = 2;
      this.track.EdgeWidth = 2;
      this.track.Location = new System.Drawing.Point(0, 0);
      this.track.Name = "track";
      this.track.OriginalImage = global::Tibia_Utilities.Properties.Resources.TrackVScrollBar;
      this.track.Size = new System.Drawing.Size(16, 79);
      this.track.TabIndex = 3;
      // 
      // thumb
      // 
      this.thumb.EdgeHeight = 8;
      this.thumb.EdgeWidth = 6;
      this.thumb.Location = new System.Drawing.Point(0, 16);
      this.thumb.Name = "thumb";
      this.thumb.OriginalImage = global::Tibia_Utilities.Properties.Resources.ThumbScrollBar;
      this.thumb.Size = new System.Drawing.Size(16, 47);
      this.thumb.TabIndex = 4;
      // 
      // up
      // 
      this.up.Cursor = System.Windows.Forms.Cursors.Hand;
      this.up.FlatAppearance.BorderSize = 0;
      this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.up.Image = global::Tibia_Utilities.Properties.Resources.UpScrollBarButton;
      this.up.Location = new System.Drawing.Point(0, 0);
      this.up.Margin = new System.Windows.Forms.Padding(0);
      this.up.Name = "up";
      this.up.Size = new System.Drawing.Size(16, 16);
      this.up.TabIndex = 5;
      this.up.UseVisualStyleBackColor = true;
      // 
      // down
      // 
      this.down.Cursor = System.Windows.Forms.Cursors.Hand;
      this.down.FlatAppearance.BorderSize = 0;
      this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.down.Image = global::Tibia_Utilities.Properties.Resources.DownScrollBarButton;
      this.down.Location = new System.Drawing.Point(0, 63);
      this.down.Margin = new System.Windows.Forms.Padding(0);
      this.down.Name = "down";
      this.down.Size = new System.Drawing.Size(16, 16);
      this.down.TabIndex = 6;
      this.down.UseVisualStyleBackColor = true;
      // 
      // TibiaVScrollBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.track);
      this.Name = "TibiaVScrollBar";
      this.Size = new System.Drawing.Size(16, 79);
      this.track.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private TUSlicePanel track;
    private TUSlicePanel thumb;
    private TUCtrlButton down;
    private TUCtrlButton up;
  }
}
