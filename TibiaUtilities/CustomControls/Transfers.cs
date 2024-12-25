using System;
using System.Windows.Forms;

using TibiaUtilities.CustomControls.BaseControl;
using TibiaUtilities.Lib;

namespace TibiaUtilities.CustomControls
{
  public partial class Transfers : DisplayDataPanel
  {
    int space = 10;
    private int _cant;

    public Transfers()
    {
      InitializeComponent();
    }

    public Transfers(string fromPlyer, int cant, string toPlayer)
    {
      InitializeComponent();
      _cant = cant;

      receiverLabel.Text = fromPlyer;
      cantLabel.Text = cant.ToString("N0") + " a";
      payerLabel.Text = toPlayer;

      payerLabel.ForeColor =
      receiverLabel.ForeColor = TUColors.LIGHT_GRAY;
      Reloc();
    }

    /// <summary>
    /// Setea el profit que obtiene cada player
    /// </summary>
    /// <param name="profit"></param>
    public Transfers(int profit)
    {
      InitializeComponent();
      receiverLabel.Text = "Total Profit each: ";
      cantLabel.Text = profit.ToString("N0");
      goldCoinPicture.Left = receiverLabel.Left;
      goldCoinPicture.Top = receiverLabel.Top + receiverLabel.Height + space;
      cantLabel.Top = (goldCoinPicture.Top + (goldCoinPicture.Height / 2)) - (cantLabel.Height / 2);
      cantLabel.Left = goldCoinPicture.Left + goldCoinPicture.Width + space;
      lblA.Visible =
      payerLabel.Visible = false;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      foreach (Control control in Controls)
      {
        control.Click += CopyToClipboard_Click;
      }
    }

    private void Reloc()
    {
      lblA.Left = receiverLabel.Left + receiverLabel.Width;
      goldCoinPicture.Left = lblA.Left + lblA.Width;
      cantLabel.Left = goldCoinPicture.Left + goldCoinPicture.Width;
      payerLabel.Left = cantLabel.Left + cantLabel.Width;
    }

    private void CopyToClipboard_Click(object sender, EventArgs e)
    {
      try
      {
        Clipboard.SetText(_cant.ToString());
        MessageBox.Show($"Amount({_cant}) copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Failed to copy amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
