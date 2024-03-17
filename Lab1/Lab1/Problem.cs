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
    internal class Problem
    {
        int n;
        Random random;
        public List<Item> items = new List<Item>();

        public Problem(int n, int seed)
        {
            this.n = n;
            random = new Random(seed);
            MakeList();
        }

        void MakeList()
        {
            for (int i = 0; i < n; i++)
            {
                Item item = new Item(random.Next(1,9), random.Next(1,9), i);
                items.Add(item);
            }
        }

        public void ShowList()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("item: ");
                Console.Write(items[i].id);
                Console.Write(", weight: ");
                Console.Write(items[i].weight);
                Console.Write(" value: ");
                Console.Write(items[i].value);
                Console.Write(" ratio: ");
                Console.WriteLine(items[i].ratio);
            }
        }


        public Result Solve(int capacity)
        {
            items.Sort((a, b) => a.ratio.CompareTo(b.ratio));
            items.Sort((a, b) => b.ratio.CompareTo(a.ratio));

            Result result = new Result(capacity);

            int amount = 0;
            bool success = true;

            while (amount < capacity && success)
            {
                success = false;
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].used == false && items[i].weight <= capacity - amount)
                    {
                        items[i].used = true;
                        amount += items[i].weight;
                        result.backpack.Add(items[i]);
                    }
                }
            }
            result.Measure();
            return result;

        }
    }
}
