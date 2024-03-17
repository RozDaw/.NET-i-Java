namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int seed = 0;
            int capacity = 0;
            if (int.TryParse(textBox1.Text, out n) && 
                int.TryParse(textBox2.Text, out seed) && 
                int.TryParse(textBox3.Text, out capacity))
            {
                label7.Visible = false;
                Problem problem = new Problem(n, seed);

                listBox2.Items.Clear();
                string[] list = problem.ToString().Split('\n');
                foreach (string s in list) listBox2.Items.Add(s);

                Result result = new Result(capacity);
                result = problem.Solve(capacity);

                listBox1.Items.Clear();
                string[] results = result.ToString().Split('\n');
                foreach (string s in results) listBox1.Items.Add(s);
            }
            else
            {
                label7.Visible = true;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
