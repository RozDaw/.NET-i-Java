using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Drawing;
using System;
using System.Numerics;

namespace lab3
{
    public partial class Form1 : Form
    {
        public static Form1 gui;
        public static readonly object locker = new object();

        public Form1()
        {
            InitializeComponent();
            numericUpDown3.Controls.RemoveAt(0);
            numericUpDown4.Controls.RemoveAt(0);
            gui = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Stopwatch sw = new Stopwatch();
            label6.Text = " . . . ";
            listBox1.Items.Clear();
            int size = (int)numericUpDown2.Value;
            int num_threads = (int)numericUpDown1.Value;

            Matrix matrix1 = new Matrix(size, (int)numericUpDown3.Value);
            Matrix matrix2 = new Matrix(size, (int)numericUpDown4.Value);

            Result result = new Result(size, num_threads, matrix1.matrix, matrix2.matrix);

            sw.Start();
            result.Start();
            sw.Stop();

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            label6.Text = "Time: " + elapsedTime + " [h:m:s.ms]";
            sw.Restart();

            if (checkBox1.Checked)
            {
                textBox1.Text = matrix1.ToString();
                textBox2.Text = matrix2.ToString();
                textBox3.Text = result.ToString();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Segoe UI", trackBar1.Value);
            textBox2.Font = new Font("Segoe UI", trackBar1.Value);
            textBox3.Font = new Font("Segoe UI", trackBar1.Value);
        }
    }
}
