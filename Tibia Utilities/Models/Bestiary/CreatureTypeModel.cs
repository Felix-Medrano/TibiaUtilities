using System.Drawing;
using System.IO;
using System.Net;

namespace Tibia_Utilities.Models.Bestiary
{
  public class CreatureTypeModel
  {
    public string Name { get; set; }
    public string Image { get; set; }

    // Propiedad auxiliar para trabajar con System.Drawing.Image
    public Image ImageObject
    {
      get
      {
        try
        {
          using (WebClient wc = new WebClient())
          {
            byte[] bytes = wc.DownloadData(Image);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
              return System.Drawing.Image.FromStream(ms);
            }
          }
        }
        catch
        {
          return null;
        }
      }
    }
  }
}
