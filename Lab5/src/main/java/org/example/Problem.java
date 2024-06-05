package org.example;

import java.util.*;

public class Problem
{
    public int n;
    public int capacity;
    List<Item> items = new ArrayList<>();
    Random random;

    Problem(int n, int cap, int seed, int lowerBound, int upperBound)
    {
        this.n = n;
        capacity = cap;
        random = new Random(seed);
        MakeProblem(lowerBound, upperBound);
    }

    private void MakeProblem(int lowerBound, int upperBound)
    {
        for (int i = 0; i < n; i++)
        {
            Item item = new Item(random.nextInt(lowerBound,upperBound), random.nextInt(lowerBound,upperBound), i);
            items.add(item);
        }
    }

    public void Solve()
    {
        //items.sort((s1, s2) -> s1.ratio - s2.ratio);
        Collections.sort(items, new Comparator<Item>()
        {
            @Override
            public int compare(Item o1, Item o2) {
                return Float.compare(o2.ratio, o1.ratio);
            }
        });

    }

    @Override
    public String toString()
    {
        String s = "";
        for (int i = 0; i < n; i++)
        {
            s += "item: ";
            s += items.get(i).id;
            s += ",\t weight: ";
            s += items.get(i).weight;
            s += "\t value: ";
            s += items.get(i).value;
            s += "\t ratio: ";
            s += items.get(i).ratio+"\n";
        }
        return s;
    }
}
