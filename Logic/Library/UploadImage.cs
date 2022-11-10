using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class UploadImage
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        
        public void LoadImage(PictureBox picturebox)
        {
            // Establises the propertie of WaitOnLoad to true
            picturebox.WaitOnLoad = true;
            // We filter the file type
            ofd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            // We show the window
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)
            {
                picturebox.ImageLocation = ofd.FileName;
            }
        }
    }
}
