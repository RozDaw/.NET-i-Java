using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private HttpClient client;

        private async void button1_Click(object sender, EventArgs e)
        {
            client = new HttpClient();

            //string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";

            string town = "Wroclaw";
            if (textBox2.Text != "")    town = textBox2.Text;
            town.Replace(' ', '+');
            string call = "https://api.openweathermap.org/data/2.5/weather?q=";
            call += town;
            call += "&appid=04ffe381afd94e9cf145d88ce1021330";

            try
            {
                string response = await client.GetStringAsync(call);
                WeatherInfo weatherinfo = JsonSerializer.Deserialize<WeatherInfo>(response);
                textBox1.Text = weatherinfo.ToString();
            }
            catch (Exception ex) 
            {
                textBox1.Text = "City name not found";
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            // If the TextBox contains text, change its foreground and background colors.
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.ForeColor = Color.Red;
                textBox1.BackColor = Color.Black;
                // Move the selection pointer to the end of the text of the control.
                textBox1.Select(textBox1.Text.Length, 0);
            }
        }

    }
}
