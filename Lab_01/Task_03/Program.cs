using System;

namespace Lab_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            TestHashSet testHashSet = new TestHashSet();
            Console.WriteLine("Test check all: "+ testHashSet.Test_check_all().ToString()
                                + "\nTest check single: "+ testHashSet.Test_check_single().ToString());
        }
    }
}
