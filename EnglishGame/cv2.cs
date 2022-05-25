using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh3
{
    internal class cv2
    {
        public static Image imread(string path)
        {
            Image result = Image.FromFile(path);
            
            return result;
        }

        public static Image resize(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, size);
            return (Image)bm;
        }


    }
}
