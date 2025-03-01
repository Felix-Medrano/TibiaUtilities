using System;
using System.Drawing;
using System.Windows.Forms;

using Tibia_Utilities.Lib;
using Tibia_Utilities.Models.SplitLoot;

namespace Tibia_Utilities.CustomControls.SplitLoot
{
  public partial class PlayerTransfer : UserControl
  {
    private TransferModel transferModel;

    public PlayerTransfer()
    {
      InitializeComponent();
      DoubleBuffered = true;

      SetLblConfig();

      //Dummy data
      transferModel = new TransferModel
      {
        Receiver = "Lightbringer",
        Amount = 141892,
        Payer = "Mateusz Dragon Wielki"
      };

      SetData(transferModel);

      copyBtn.Click += CopyButton_Click;

    }

    private void CopyButton_Click(object sender, System.EventArgs e)
    {
      string txt = $"Transfer {transferModel.Amount} to {transferModel.Receiver}";
      Clipboard.SetText(txt);
      Console.WriteLine($"Copied to clipboard: \n-{txt}");
    }

    private void SetLblConfig()
    {
      lblPayer.Font =
      lblAmount.Font =
      lblReceiver.Font = Helper.safeFont10;

      lblPayer.ForeColor =
      lblAmount.ForeColor =
      lblReceiver.ForeColor = Helper.HexToColor(TUStrings.Colors.DESC_TEXT_COLOR);
    }

    private void AlignContent()
    {
      int offsetX = 10;
      foreach (Control control in viewPort.Controls)
      {
        if (control is TUSlicePanel)
          continue;

        int locY = (topPanel.Height + ((viewPort.Height - topPanel.Height) / 2)) - control.Height / 2;

        if (control is TUCtrlButton)
        {
          control.Location = new Point(viewPort.Width - control.Width - 5, locY);
          continue;
        }


        control.Location = new Point(offsetX, locY);
        offsetX += control.Width + 5;
      }
    }

    public void SetData(TransferModel transfer)
    {
      transferModel = transfer;
      lblReceiver.Text = transfer.Receiver;
      lblAmount.Text = transfer.Amount.ToString("N0");
      lblPayer.Text = transfer.Payer;
      AlignContent();
    }
  }
}
