using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Practica04
{
  public class ConvertImage
  {
    public static Image ByteArrayToImage(byte[] byteArrayIn)
    {
      MemoryStream ms = new MemoryStream(byteArrayIn);
      return Image.FromStream(ms);
    }

    public static byte[] ImageToByteArray(Image imageIn)
    {
      MemoryStream ms = new MemoryStream();
      imageIn.Save(ms, ImageFormat.Jpeg);
      return ms.ToArray();
    }
  }
}
