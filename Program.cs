using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Tworzymy przykładową nieposortowaną tablicę liczb całkowitych
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        // Wyświetlamy stan tablicy przed wykonaniem algorytmu
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(numbers);

        // Wywołujemy naszą metodę sortującą
        BubbleSort(numbers);

        // Wyświetlamy wynik po posortowaniu
        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(numbers);
    }

    public static void BubbleSort(int[] array)
    {
        // WARUNEK BEZPIECZEŃSTWA: Jeśli tablica jest null lub nie ma elementów, natychmiast kończymy
        if (array == null || array.Length == 0) return;

        // WALIDACJA (Test negatywny): Ograniczenie rozmiaru tablicy do 1000 elementów.
        // Przekroczenie tego limitu wyrzuci wyjątek ArgumentException.
        if (array.Length > 1000)
        {
            throw new ArgumentException("Tablica jest zbyt duża do sortowania bąbelkowego!");
        }

        int n = array.Length;

        // PĘTLA ZEWNĘTRZNA: Określa liczbę przejść przez tablicę (max n - 1 razy).
        // Liczymy od 0, więc dla 5 elementów wykona przejścia dla i = 0, 1, 2, 3 (łącznie 4 razy).
        for (int i = 0; i < n - 1; i++)
        {
            // PĘTLA WEWNĘTRZNA: Porównuje sąsiadujące ze sobą elementy.
            // Odejmujemy 'i', ponieważ po każdym przejściu kolejny największy element stoi już na swoim miejscu na końcu.
            // Odejmujemy '1', aby nie wyjść poza zakres tablicy przy odwołaniu do array[j + 1].
            for (int j = 0; j < n - i - 1; j++)
            {
                // Jeśli lewy element jest większy od prawego, zamieniamy je miejscami (wypychamy większą liczbę w prawo)
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];       // KROK 1: Chwilowo zapisujemy wartość z lewej komórki w zmiennej tymczasowej
                    array[j] = array[j + 1];   // KROK 2: Nadpisujemy lewą komórkę wartością z prawej komórki
                    array[j + 1] = temp;       // KROK 3: Prawa komórka otrzymuje starą wartość lewej komórki przechowaną w temp
                }
            }
        }
    }

    public static void PrintArray(int[] array)
    {
        // Zabezpieczenie przed błędem w przypadku braku tablicy
        if (array == null) return;

        // string.Join automatycznie łączy elementy tablicy w jeden tekst oddzielony przecinkami
        Console.WriteLine(string.Join(", ", array));
    }
}