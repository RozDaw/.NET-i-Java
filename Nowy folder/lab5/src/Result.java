import java.util.ArrayList;
import java.util.List;

public class Result
{
    List<Przedmiot> przedmioty;
    int sumarycznaWartosc;
    int sumarycznaWaga;

    Result() {
        przedmioty = new ArrayList<>();
        sumarycznaWartosc = 0;
        sumarycznaWaga = 0;
    }

    void dodajPrzedmiot(Przedmiot przedmiot) {
        przedmioty.add(przedmiot);
        sumarycznaWartosc += przedmiot.wartosc;
        sumarycznaWaga += przedmiot.waga;
    }

    @Override
    public String toString() {
        return String.format("Result: %s \n\nsumarycznaWartosc=%d \nsumarycznaWaga=%d}", przedmioty, sumarycznaWartosc, sumarycznaWaga);
    }
}
