using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class City
    {
        public int Id { get; set; }
        public required string name { get; set; }
        public required float lon {  get; set; }
        public required float lat { get; set; }
        public string? description {  get; set; }
        public float temp {  get; set; }
        public float feels_like {  get; set; }
        public float? pressure {  get; set; }
        public float? humidity {  get; set; }
        public float? speed {  get; set; }

        public override string ToString()
        {
            string answer = "";
            answer += $"Location: {name} \r\n";
            answer += $"lon: {lon}, lat: {lat} \r\n";
            answer += $"Weather: {description} \r\n";
            answer += $"Wind speed: {speed} m/s \r\n";
            answer += $"Temperature: {(temp - 273.15).ToString(".#")} ºC, ";
            answer += $"Feels like: {(feels_like - 273.15).ToString(".#")} ºC \r\n";
            answer += $"Pressure: {pressure} hPa \r\n";
            answer += $"Humidity: {humidity} % \r\n";
            return answer;
        }
    }
}
