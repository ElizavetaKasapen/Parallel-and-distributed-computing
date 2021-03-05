using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();
            Stopwatch stopwatch = new Stopwatch();
            Work_with_file work_with_file = new Work_with_file();
            Dictionary<int, double> int_by_rows = new Dictionary<int, double>();
            Dictionary<int, double> int_by_columns = new Dictionary<int, double>();
            Dictionary<int, double> float_by_rows = new Dictionary<int, double>();
            Dictionary<int, double> float_by_columns = new Dictionary<int, double>();
            for (int i = 0; i <= 12000; i += 50)
            {
                //int by_rows
                int bytes = i * i * 4 / 1024;
                stopwatch.Restart();
                actions.Fill_by_row_int(i);
                stopwatch.Stop();
                int_by_rows.Add(bytes, stopwatch.Elapsed.TotalMilliseconds);
                //int by_columns
                stopwatch.Restart();
                actions.Fill_by_column_int(i);
                stopwatch.Stop();
                int_by_columns.Add(bytes, stopwatch.Elapsed.TotalMilliseconds);

                //float by_rows
                stopwatch.Restart();
                actions.Fill_by_row_float(i);
                stopwatch.Stop();
                float_by_rows.Add(bytes, stopwatch.Elapsed.TotalMilliseconds);
                //int by_columns
                stopwatch.Restart();
                actions.Fill_by_column_float(i);
                stopwatch.Stop();
                float_by_columns.Add(bytes, stopwatch.Elapsed.TotalMilliseconds);
            }
            //download data to files
            work_with_file.Write_to_file(int_by_rows, "int_by_rows.txt");
            work_with_file.Write_to_file(int_by_columns, "int_by_columns.txt");
            work_with_file.Write_to_file(float_by_rows, "float_by_rows.txt");
            work_with_file.Write_to_file(float_by_columns, "float_by_columns.txt");
        }
    }
}
