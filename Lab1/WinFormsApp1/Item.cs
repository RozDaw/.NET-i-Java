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
    internal class Item
    {
        public int id;
        public int weight;
        public int value;
        public bool used;
        public float ratio;

        public Item(int w, int v, int i)
        {
            weight = w;
            value = v;
            id = i;
            used = false;
            ratio = (float)value / (float)weight;
        }
    }
}
