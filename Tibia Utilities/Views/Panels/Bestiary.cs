using System;
using System.Windows.Forms;

using Tibia_Utilities.Core;
using Tibia_Utilities.Core.Bestiary;
using Tibia_Utilities.CustomControls;
using Tibia_Utilities.CustomControls.Bestiary;
using Tibia_Utilities.Interfaces.Panels;

namespace Tibia_Utilities.Views.Panels
{
  public partial class Bestiary : Form, IViewPanel
  {
    private ObjectPool<CreatureType> _creatureTypePool;

    public Bestiary()
    {
      InitializeComponent();

      _creatureTypePool = new ObjectPool<CreatureType>(94);

      CreatureTypeLoad();
    }

    private void CreatureTypeLoad()
    {
      var creatureTypes = new CreatureTypes();
      foreach (var creatureType in creatureTypes.Items)
      {
        var typeControl = new CreatureType();
        typeControl.SetTitle(creatureType.Name);
        typeControl.SetImage(creatureType.ImageObject);
        CreatureTypeLayOut.Controls.Add(typeControl);
      }

      container.Height = ((int)Math.Ceiling((double)creatureTypes.Items.Count / 5) * (new CreatureType().Height)) + 5;

      VScrollBar.UpdateThumbHeight();
    }

    private void ContainerDispose()
    {

    }

    public void SetViewPanel(TUPanel panel)
    {
      panel.Controls.Clear();
      panel.Controls.Add(viewPanel);
    }
  }
}
