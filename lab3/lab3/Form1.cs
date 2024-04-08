using System.Drawing.Drawing2D;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 6;
            Matrix matrix1 = new Matrix(size, 100);
            textBox1.Text = matrix1.ToString();

            Matrix matrix2 = new Matrix(size, 45);
            textBox2.Text = matrix2.ToString();

            Multiplication multiplication = new Multiplication(matrix1.matrix, matrix2.matrix, size);
            //textBox3.Text = multiplication.result.ToString();
        }
    }
}
