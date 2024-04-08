using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class WeatherInfo
    {

        public Coord coord { get; set; }
        public Weather[] weather { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }

        public string name { get; set; }

        public override string ToString()
        {
            string answer = "";
            answer += $"Location: {name} \r\n";
            answer += $"lon: {coord.lon}, lat: {coord.lat} \r\n";
            answer += $"Weather: {weather[0].description} \r\n";
            answer += $"Wind speed: {wind.speed} m/s \r\n";
            answer += $"Temperature: {(main.temp - 273.15).ToString(".#")} ºC, ";
            answer += $"Feels like: {(main.feels_like-273.15).ToString(".#")} ºC \r\n";
            answer += $"Pressure: {main.pressure} hPa \r\n";
            answer += $"Humidity: {main.humidity} % \r\n";
            return answer;
        }
    }

    internal class Coord
    { 
        public float lat { get; set; }
        public float lon { get; set; }
    }
    
    internal class Weather
    {
        public string description { get; set; }
    }

    internal class Main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float pressure { get; set; }
        public float humidity { get; set; }
    }
    
    internal class Wind
    {
        public float speed { get; set; }
    }


}
