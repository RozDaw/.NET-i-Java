import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Random;

public class Problem
{
    int liczbaRodzajowPrzedmiotow;
    Random random;
    int dolnyZakres;
    int gornyZakres;
    List<Przedmiot> przedmioty;

    Problem(int n, int lowerBound, int upperBound)
    {
        this(n, System.currentTimeMillis(), lowerBound, upperBound);
    }

    Problem(int n, long seed, int lowerBound, int upperBound)
    {

        liczbaRodzajowPrzedmiotow = n;
        random = new Random(seed);
        dolnyZakres = lowerBound;
        gornyZakres = upperBound;
        przedmioty = new ArrayList<>();

        for (int i = 0; i < n; i++)
        {
            int waga = random.nextInt(upperBound - lowerBound + 1) + lowerBound;
            int wartosc = random.nextInt(upperBound - lowerBound + 1) + lowerBound;
            przedmioty.add(new Przedmiot(waga, wartosc));
        }
    }

    public Result solve(int capacity)
    {
        przedmioty.sort(Comparator.comparingDouble(Przedmiot::ratio).reversed());

        Result result = new Result();
        int aktualnaPojemnosc = capacity;

        for (Przedmiot przedmiot : przedmioty)
        {
            while (aktualnaPojemnosc >= przedmiot.waga)
            {
                result.dodajPrzedmiot(przedmiot);
                aktualnaPojemnosc -= przedmiot.waga;
            }
        }

        return result;
    }

    @Override
    public String toString()
    {
        return String.format("Problem: %s \n", przedmioty);
    }


}
