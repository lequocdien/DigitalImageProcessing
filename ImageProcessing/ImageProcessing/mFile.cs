using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    class mFile 
    {
       public static Bitmap OpenFile()
        {
            Bitmap bm = null;
            OpenFileDialog OpenFile = new OpenFileDialog();
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                string path = OpenFile.FileName;
                bm = new Bitmap(path);
            }
            return bm;
        }
        public static void SaveFile(PictureBox picBox)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "JPG File| *.jpg";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                picBox.Image.Save(SaveFile.FileName);
            }
        }
    }
}
