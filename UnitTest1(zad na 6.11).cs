using System;
using System.IO;
using Xunit;

public class MójSerwisSortujący
{
    // Prosta metoda łącząca odczyt z pliku, sortowanie i zapis
    public void SortujPlik(string sciezkaWejsciowa, string sciezkaWyjsciowa)
    {
        // 1. Odczytujemy liczby z pliku
        string[] linie = File.ReadAllLines(sciezkaWejsciowa);
        int[] liczby = Array.ConvertAll(linie, int.Parse);

        // 2. Sortujemy bąbelkowo
        for (int i = 0; i < liczby.Length - 1; i++)
        {
            for (int j = 0; j < liczby.Length - i - 1; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    int temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }

        // 3. Zapisujemy wynik do nowego pliku
        string[] posortowaneLinie = Array.ConvertAll(liczby, n => n.ToString());
        File.WriteAllLines(sciezkaWyjsciowa, posortowaneLinie);
    }
}

// Test integracyjny sprawdzający współpracę z plikami na dysku
public class TestyIntegracyjne
{
    [Fact]
    public void Test_Czy_Plik_Poprawnie_Sie_Sortuje()
    {
        // Przygotowanie plików tymczasowych
        string wejscie = Path.GetTempFileName();
        string wyjscie = Path.GetTempFileName();

        // Wrzucamy nieposortowane liczby do pliku wejściowego
        File.WriteAllLines(wejscie, new[] { "9", "1", "5" });

        var serwis = new MójSerwisSortujący();

        // Uruchomienie testowanej funkcji
        serwis.SortujPlik(wejscie, wyjscie);

        // Sprawdzenie wyniku
        string[] wynik = File.ReadAllLines(wyjscie);
        int[] liczbyWynikowe = Array.ConvertAll(wynik, int.Parse);

        // Oczekiwany wynik to: 1, 5, 9
        Assert.Equal(new[] { 1, 5, 9 }, liczbyWynikowe);

        // Sprzątanie po teście
        File.Delete(wejscie);
        File.Delete(wyjscie);
    }
}