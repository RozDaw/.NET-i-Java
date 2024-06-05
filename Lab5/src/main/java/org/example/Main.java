package org.example;

public class Main
{
    public static void main(String[] args)
    {
        int itemsCount = 10;
        int backpackCapacity = 50;
        int seed = 5;
        int lowerBound = 1;
        int upperBound = 10;
        Problem problem = new Problem(itemsCount, backpackCapacity, seed, lowerBound, upperBound);

        System.out.println(problem);
        problem.Solve();
        System.out.println();
        System.out.println(problem);
    }
}