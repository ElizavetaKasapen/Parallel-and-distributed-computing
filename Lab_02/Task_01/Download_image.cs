using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace Lab_02
{
    class Download_image
    {
        public void Remote(String imageURL)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(imageURL, "D:\\University\\4.2\\Pictures\\" + Path.GetFileName(imageURL));
            }
        }

        public void Local(String imagePath)
        {
            Bitmap img = new Bitmap(imagePath);
            img.Save(@"D:\University\4.2\Pictures_to_save\" + Path.GetFileName(imagePath));
        }
    }
}
