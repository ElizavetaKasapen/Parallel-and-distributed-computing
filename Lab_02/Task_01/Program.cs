using System;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Download_image download_Image = new Download_image();
            Stopwatch stopwatch = new Stopwatch();
            //links
            String[] imagesURL = new String[] { 
            "https://bipbap.ru/wp-content/uploads/2017/04/krasivye_kollazh_na_temu_prirody_1920x1200.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/242624_565001.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/krasivye-kartinki-Priroda-2278640.jpeg",
            "https://bipbap.ru/wp-content/uploads/2017/04/wallpapers-nature-16.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/voshod_solnca_priroda_pole_mostik_4499x2231.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/v2.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/priroda_kartinki_foto_05.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/priroda_kartinki_foto_01.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/priroda_05.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/priroda_01.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/plitvickiye-ozera-1.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/maxresdefault-10.jpg",
            "https://bipbap.ru/wp-content/uploads/2017/04/maxresdefault-1-4.jpg"
            };
            stopwatch.Restart();
            foreach (String url in imagesURL)
            {
                download_Image.Remote(url);
            }
            stopwatch.Stop();
            Console.WriteLine("Remote: " + stopwatch.Elapsed.TotalMilliseconds.ToString());

            string[] files = Directory.GetFiles("D:\\University\\4.2\\Pictures\\");
            stopwatch.Restart();
            foreach (string path in files)
            {
                download_Image.Local(path);
            }
            stopwatch.Stop();
            Console.WriteLine("Local: " + stopwatch.Elapsed.TotalMilliseconds.ToString());
        }
    }
}
