using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace Lab_02_02
{
    class Download_images
    {
        
        
        public void Remote(String url)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(url, "D:\\University\\4.2\\Pictures\\" + Path.GetFileName(url));
            }
        }

        public void Local(String path)
        {
                Bitmap img = new Bitmap(path);
                img.Save(@"D:\University\4.2\Pictures_to_save\" + Path.GetFileName(path));
        }
    }
}
