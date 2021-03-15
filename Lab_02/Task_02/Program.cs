using System;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Download_images download_Image = new Download_images();
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
            string[] files = Directory.GetFiles(@"D:\University\4.2\Pictures\");
            Console.WriteLine("**Remote**");
            // i - number of threads
            // loop for remote access
            for (int i = 2; i <= 10; i += 2)
            {
                stopwatch.Restart();
                Parallel.ForEach(imagesURL, new ParallelOptions { MaxDegreeOfParallelism = i }, webpage => { download_Image.Remote(webpage); });
                stopwatch.Stop();
                Console.WriteLine("Number of threads: " + i +"\tResult: "+ stopwatch.Elapsed.TotalMilliseconds.ToString() + " milliseconds");
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("**Local**");
            // loop for local access
            for (int i = 2; i <= 10; i += 2)
            {
                stopwatch.Restart();
                Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = i }, file => { download_Image.Local(file); });
                stopwatch.Stop();
                Console.WriteLine("Number of threads: " + i + "\tResult: " + stopwatch.Elapsed.TotalMilliseconds.ToString() + " milliseconds");
            }

        }
    }
}


