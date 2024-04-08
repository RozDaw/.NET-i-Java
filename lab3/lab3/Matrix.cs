using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Matrix
    {
        Random random;
        public int[,] matrix;
        int size;

        public Matrix(int size, int seed)
        {
            random = new Random(seed);
            matrix = new int[size, size];
            this.size = size;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = random.Next(1, 9);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    s += matrix[i, j];
                    s += "   ";
                }
                s += "\r\n";
            }
            
            return s;
        }
    }
}
