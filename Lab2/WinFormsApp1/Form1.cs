using Microsoft.VisualBasic.Logging;
using System.Drawing;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Windows;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private bool byName = true;
        private bool reversed = false;
        private DataBasee databasee;

        public Form1()
        {
            InitializeComponent();
            databasee = new DataBasee();
            databasee.Cities.RemoveRange(databasee.Cities);
            databasee.SaveChanges();
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
        }

        private HttpClient client;


        private async void button1_Click(object sender, EventArgs e)
        {

            client = new HttpClient();

            string town = textBox2.Text;
            if (town == "") town = "Wroclaw";

            string cityName = town.ToLower().Replace('¹', 'a').Replace('æ', 'c').Replace('ê', 'e').Replace('³', 'l').Replace('ñ', 'n')
                                             .Replace('ó', 'o').Replace('¹', 'a').Replace('œ', 's').Replace('¿', 'z').Replace('Ÿ', 'z');

            textBox2.Text = cityName;
            if (databasee.Cities.Any(s => s.name == cityName))
            {
                textBox1.Text = "City already exist in database";
                textBox2.Text = "";
                return;
            }

            town.Replace(' ', '+');

            
            string call = "https://api.openweathermap.org/data/2.5/weather?q=";
            call += town;
            call += "&appid=04ffe381afd94e9cf145d88ce1021330";

            try
            {
                string response = await client.GetStringAsync(call);
                WeatherInfo weatherinfo = JsonSerializer.Deserialize<WeatherInfo>(response);
                textBox1.Text = weatherinfo.ToString();
                textBox2.Text = "";

                

                listBox1.DataSource = null;
                databasee.Cities.Add(new City() { name = weatherinfo.name.ToLower().Replace('¹', 'a').Replace('æ', 'c').Replace('ê', 'e').Replace('³', 'l').Replace('ñ', 'n')
                    .Replace('ó', 'o').Replace('¹', 'a').Replace('œ', 's').Replace('¿', 'z').Replace('Ÿ', 'z'), lat = weatherinfo.coord.lat, lon = weatherinfo.coord.lon, 
                    description = weatherinfo.weather[0].description, temp = weatherinfo.main.temp, feels_like = weatherinfo.main.feels_like, pressure = weatherinfo.main.pressure,
                    humidity = weatherinfo.main.humidity, speed = weatherinfo.wind.speed});

                databasee.SaveChanges();
                if (byName) listBox1.DataSource = databasee.Cities.OrderBy(s => s.name).Reverse().ToList<City>();
                else listBox1.DataSource = databasee.Cities.OrderBy(s => s.Id).Reverse().ToList<City>();
                reversed = false;
            }
            catch (Exception ex)
            {
                textBox1.Text = "City name not found";
                textBox2.Text = "";
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = databasee.Cities.OrderBy(s => s.Id).Reverse().ToList<City>();
            byName = false;
            reversed = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = databasee.Cities.OrderBy(s => s.name).Reverse().ToList<City>();
            byName = true;
            reversed = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (byName)
            {
                if (reversed)
                {
                    listBox1.DataSource = databasee.Cities.OrderBy(s => s.name).Reverse().ToList<City>();
                    reversed = false;
                }
                else
                {
                    listBox1.DataSource = databasee.Cities.OrderBy(s => s.name).ToList<City>();
                    reversed = true;
                }
            }

            if (!byName)
            {
                if (reversed)
                {
                    listBox1.DataSource = databasee.Cities.OrderBy(s => s.Id).Reverse().ToList<City>();
                    reversed = false;
                }
                else
                {
                    listBox1.DataSource = databasee.Cities.OrderBy(s => s.Id).ToList<City>();
                    reversed = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) 
            {
                string str = listBox1.SelectedItem.ToString();
                str = str.Substring(str.IndexOf(" ") + 1);
                str = str.Substring(0, str.IndexOf(":"));
                string city = str.Remove(str.Length - 6);

                listBox1.DataSource = null;

                var town = databasee.Cities.First(s => s.name == city);
                databasee.Cities.Remove(town);
                databasee.SaveChanges();


                if (byName) listBox1.DataSource = databasee.Cities.OrderBy(s => s.name).Reverse().ToList<City>();
                else listBox1.DataSource = databasee.Cities.OrderBy(s => s.Id).Reverse().ToList<City>();

            }
        }

        private void listBox1_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                textBox1.Text = listBox1.Items[index].ToString(); //databasee.Cities.First(s => s.name == listBox1.Items.)
            }
        }

    }
}   
