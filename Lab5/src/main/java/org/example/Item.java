package org.example;

public class Item
{
    public int id;
    public float ratio;
    public int usedCount;
    public int value;
    public int weight;

    Item(int v, int w, int i)
    {
        value = v;
        weight = w;
        id = i;
        usedCount = 0;
        ratio = (float) value/weight;
    }

    public float GetRatio()
    {
        return ratio;
    }
}
