using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp.Util
{
    public class ConvertImage
    {

        // đặt lại kích thước ảnh
        public Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        // chuyển ảnh về chuỗi
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Lưu ảnh vào MemoryStream
                image.Save(ms, format);

                // Chuyển MemoryStream thành mảng byte
                byte[] imageBytes = ms.ToArray();

                // Chuyển mảng byte thành chuỗi Base64
                return Convert.ToBase64String(imageBytes);
            }
        }

        // chuyển chuỗi về ảnh
        public Image Base64ToImage(string base64String)
        {
            // Chuyển chuỗi Base64 thành mảng byte
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Tạo MemoryStream từ mảng byte
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                // Sử dụng MemoryStream để tạo lại đối tượng Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        public Image ImageToPath(string path)
        {
            Image img = null; ;
            try
            {
                img = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
            }
            return img;
        }
    }
}
