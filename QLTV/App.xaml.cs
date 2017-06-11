using QLTV.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using QLTV.View_Models;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace QLTV
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static View_Models.Role role;
        public static UserController usercontroll;
        public static Role Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            usercontroll = new UserController();
        }
        public static byte[] ConvertFileToByte(ImageSource path)
        {
            //byte[] data = null;
            //FileInfo finfo = new FileInfo(path);
            //long numBytes = finfo.Length;
            //FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            //BinaryReader br = new BinaryReader(fstream);
            //data = br.ReadBytes((int)numBytes);
            //return data;
        try
            {
                byte[] buffer;
                var bitmap = path as BitmapSource;
                var encoder = new PngBitmapEncoder(); // or one of the other encoders
                encoder.Frames.Add(BitmapFrame.Create(bitmap));

                using (var stream = new MemoryStream())
                {
                    encoder.Save(stream);
                    buffer = stream.ToArray();
                }
                return buffer;
            }
          catch { return null; }
        }
        public static BitmapImage ConvertByteArrayToBitmapImage(Byte[] bytes)
        {
            try
            {
                var stream = new MemoryStream(bytes);
                stream.Seek(0, SeekOrigin.Begin);
                var image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = stream;
                image.EndInit();
                return image;
            }
            catch { return null; }

        }
    }
}
