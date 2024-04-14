using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    internal class Result 
    {
        public int[,] matrix, m1, m2;
        int size;
        int num_threads;
        public Result(int size, int num_threads, int[,] a, int[,] b)
        {
            this.size = size;
            this.num_threads = num_threads;
            m1 = a;
            m2 = b;
            matrix = new int[size, size];
        }

        void Calculate()
        {
            int num = Int32.Parse(Thread.CurrentThread.Name);

            int kwant = (size - 1) / num_threads;
            int top = kwant + kwant * num;
            int low = top - kwant;
            if (num != 0) low++;
            if (num == num_threads - 1) top = size - 1;

            Form1.gui.listBox1.Items.Add("Thread " + num + " has started (" + low + " to " + top + " )");

            for (int i = low; i <= top; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = 0;
                    for (int k = 0; k < size; k++)
                    {
                        matrix[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }

            Form1.gui.listBox1.Items.Add("Thread " + num.ToString() + " ended");
        }

        public void Start()
        {
            Thread[] threads = new Thread[num_threads];
            for (int i = 0; i < num_threads; i++)
            {
                threads[i] = new Thread(Calculate);
                threads[i].Name = String.Format(i.ToString());
            }

            foreach (Thread x in threads) x.Start();
            foreach (Thread x in threads) x.Join();
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
