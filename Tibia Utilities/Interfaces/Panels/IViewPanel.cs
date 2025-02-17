using Tibia_Utilities.CustomControls;

namespace Tibia_Utilities.Interfaces.Panels
{
  public interface IViewPanel
  {
    /// <summary>
    /// Obtiene el panel asociado con la vista.
    /// </summary>
    /// <returns>Un objeto Panel que representa la vista.</returns>
    void SetViewPanel(TUPanel panel);
  }
}
