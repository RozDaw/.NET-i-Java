using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Multiplication
    {
        int[,] matrix1;
        int[,] matrix2;
        //public int[,] result;     tutaj!!!
        int size;
        public Multiplication(int[,] m1, int[,] m2, int size)
        {
            matrix1 = m1;
            matrix2 = m2;
            this.size = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i,j] = 0;

                    for (int k = 0; k < size; k++)
                    {
                        result[i, j] += matrix1[i,0] * matrix2[0,j];
                    }

                }
            }
        }


    }
}
