using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_01_02
{
    class Actions
    {
        public void Sum_using_array(int size)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
                array[i] = i;
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum += array[i];
        }

        public void Sum_using_linked_list(int size)
        {
            LinkedList<Double> linked_list = new LinkedList<Double>();
            for (int i = 0; i < size; i++)
                linked_list.AddLast(Convert.ToDouble(i));
            double sum = 0;
            foreach (double i in linked_list)
                sum += i;
        }

        public void Sum_using_array_list(int size)
        {
            ArrayList list = new ArrayList(size);
            for (int i = 0; i < size; i++)
                list.Add(Convert.ToDouble(i));
            double sum = 0;
            foreach (double i in list)
                sum += i;
        }
    }
}
