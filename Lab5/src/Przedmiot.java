public class Przedmiot
{
    int waga;
    int wartosc;
    double ratio;

    Przedmiot(int w, int v)
    {
        waga = w;
        wartosc = v;
    }

    public double ratio()
    {
        return (double) wartosc / waga;
    }

    @Override
    public String toString()
    {
        return String.format("\nPrzedmiot{waga = %d, \t wartosc = %d, \t ratio = %f}", waga, wartosc, ratio());
    }
}
