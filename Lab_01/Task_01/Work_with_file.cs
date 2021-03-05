using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_01
{
    public class Work_with_file
    {
       public void Write_to_file(Dictionary<int, double> dict, String name)
        {
            using (var writer = new StreamWriter(name))
            {
                foreach (var pair in dict)
                {
                    writer.WriteLine($"{pair.Key}\t{pair.Value}");
                }
            }
        }
    }
}
