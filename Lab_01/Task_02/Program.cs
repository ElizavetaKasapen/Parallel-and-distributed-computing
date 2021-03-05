using System;
using Lab_01;
using System.Diagnostics;
using System.Collections.Generic;

namespace Lab_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();
            Stopwatch stopwatch = new Stopwatch();
            Work_with_file work_with_file = new Work_with_file();
            Dictionary<int, double> using_array = new Dictionary<int, double>();
            Dictionary<int, double> using_linked_list = new Dictionary<int, double>();
            Dictionary<int, double> using_array_list = new Dictionary<int, double>();

            for (int i = 0; i <= 12000; i += 50)
            {
                int bytes = i * i * 8 / 1024; // 8 because double
                //using array
                stopwatch.Restart();
                actions.Sum_using_array(i);
                stopwatch.Stop();
                using_array.Add(bytes, stopwatch.Elapsed.TotalMilliseconds);

                //using_linked_list
                stopwatch.Restart();
                actions.Sum_using_linked_list(i);
                stopwatch.Stop();
                using_linked_list.Add(bytes, stopwatch.Elapsed.TotalMilliseconds);

                //using_array_list
                stopwatch.Restart();
                actions.Sum_using_array_list(i);
                stopwatch.Stop();
                using_array_list.Add(bytes, stopwatch.Elapsed.TotalMilliseconds);
            }
            //download data to files
            work_with_file.Write_to_file(using_array, "using_array.txt");
            work_with_file.Write_to_file(using_linked_list, "using_linked_list.txt");
            work_with_file.Write_to_file(using_array_list, "using_array_list.txt");
        }
    }
}