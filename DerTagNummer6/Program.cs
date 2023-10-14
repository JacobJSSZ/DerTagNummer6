Pracownik pracownik1 = new Pracownik("Maciek", "Adamczyk", "Wiek: 38");
Pracownik pracownik2 = new Pracownik("Adrian", "Zagórsku", "Wiek: 42");
Pracownik pracownik3 = new Pracownik("Damian", "Przyński", "Wiek: 56");

pracownik1.AddScore(1);
pracownik2.AddScore(4);
pracownik3.AddScore(8);
pracownik1.AddScore(10);
pracownik2.AddScore(4);
pracownik3.AddScore(8);
pracownik1.AddScore(9);
pracownik2.AddScore(2);
pracownik3.AddScore(7);
pracownik1.AddScore(6);
pracownik2.AddScore(2);
pracownik3.AddScore(9);

var Rozwiązanie = pracownik1.Rozwiązanie;
var Rozwiązanie2 = pracownik2.Rozwiązanie2;
var Rozwiązanie3 = pracownik3.Rozwiązanie3;
Console.WriteLine(Rozwiązanie);
Console.WriteLine(Rozwiązanie2);
Console.WriteLine(Rozwiązanie3);

List<Pracownik> pracownicy = new List<Pracownik>()
{
    pracownik1, pracownik2, pracownik3
};

int max_wynik = -1;
Pracownik pracownik_with_max_wynik = null;

foreach (var pracownik in pracownicy)
{
    if (pracownik.Rozwiązanie > max_wynik)
    {
        pracownik_with_max_wynik = pracownik;
        max_wynik = pracownik.Rozwiązanie;
    }
}
Console.WriteLine("Pracownik z największą ilością punktów to:" + " " + pracownik_with_max_wynik.Imię + " " + pracownik_with_max_wynik.Nazwisko + " " + "wiek" + " " + pracownik_with_max_wynik.Wiek);
Console.WriteLine("Posiadaczem największej ilości zdobytych punktów jest" + " " + max_wynik );

public class Pracownik
{
    private List<int> wynik = new List<int>();

    public Pracownik(string imię, string nazwisko, string wiek)
    {
        this.Imię = imię;
        this.Nazwisko = nazwisko;
        this.Wiek = wiek;
    }
    public string Imię { get; private set; }

    public string Nazwisko { get; private set; }

    public string Wiek { get; private set; }

    public int Rozwiązanie4;

    public int Rozwiązanie
    {
        get
        {
            return this.wynik.Sum();
        }
    }
    public int Rozwiązanie2
    {
        get
        {
            return this.wynik.Sum();
        }
    }
    public int Rozwiązanie3
    {
        get
        {
            return this.wynik.Sum();
        }
    }
    public void AddScore(int wynik)
    {
        this.wynik.Add(wynik);
    }
}