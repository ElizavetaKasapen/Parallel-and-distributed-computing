using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;


namespace Lab_01_03
{
    class TestHashSet
    {
        public double Test_check_all(){
            Stopwatch stopwatch = new Stopwatch();
            HashSet<long> hashstructure = Create();
            //timer
            stopwatch.Restart();
            for (int i = 0; i < 10000000; i++)
            {
                long elem = i;
                Assert.IsTrue(hashstructure.Contains(elem));
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double Test_check_single()
        {
            Stopwatch stopwatch = new Stopwatch();
            HashSet<long> hashstructure = Create();
            //timer
            stopwatch.Restart();
            long elem = 0;
            for (int i = 0; i < 10000000; i++)
            {
                Assert.IsTrue(hashstructure.Contains(elem));
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        private HashSet<long> Create()
        {
            HashSet<long> hashstructure = new HashSet<long>();
            // Inserting elements in HashSet 
            for (int i = 0; i < 10000000; i++)
            {
                hashstructure.Add(i);
            }
            return hashstructure;
        }
    }
}
