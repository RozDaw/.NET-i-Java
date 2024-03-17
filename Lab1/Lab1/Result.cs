using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]

namespace Lab1
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
            string s = "Backpack content: \n";
            for (int i = 0; i < backpack.Count; i++)
            {
                s += "item: ";
                s += backpack[i].id;
                s += ", weight: ";
                s += backpack[i].weight;
                s += " value: ";
                s += backpack[i].value;
                s += " ratio: ";
                s += backpack[i].ratio;
                s += '\n';
            }
            s += '\n';
            s += "Capacity usage: ";
            s += total_weight;
            s += " / ";
            s += capacity;

            return s;
        }
    }
}
