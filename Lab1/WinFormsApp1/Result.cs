using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]

namespace WinFormsApp1
{
    internal class Result
    {
        public List<Item> backpack = new List<Item>();
        public int total_value;
        public int total_weight;
        private int capacity;

        public Result(int c)
        {
            capacity = c;
        }

        public void Measure()
        {
            total_weight = 0;
            total_value = 0;
            for (int i = 0; i < backpack.Count; i++)
            {
                total_weight += backpack[i].weight;
                total_value += backpack[i].value;
            }
        }

        public override string ToString()
        {
            Measure();
            string s = "Backpack content: \nitems: ";
            for (int i = 0; i < backpack.Count; i++)
            {
                s += backpack[i].id;
                s += " ";
            }
            s += '\n';
            s += "Total value: ";
            s += total_value;
            s += "\nTotal weight: ";
            s += total_weight;

            return s;
        }
    }
}
