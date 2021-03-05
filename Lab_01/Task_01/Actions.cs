using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01
{
    class Actions
    {
        public void Fill_by_row_int(int size)
        {
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    arr[i,j] = i * j;
            }
        }

        public void Fill_by_column_int(int size)
        {
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    arr[j, i] = i * j;
            }
        }

        public void Fill_by_row_float(int size)
        {
            float[,] arr = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    arr[i, j] = i * j;
            }
        }

        public void Fill_by_column_float(int size)
        {
            float[,] arr = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    arr[j, i] = i * j;
            }
        }

    }
}
