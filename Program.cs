using System;

class Program
{
    static void Main(string[] args)
    {
        // Deklaracja i inicjalizacja nieposortowanej tablicy liczb całkowitych
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        // Wyświetlenie elementów tablicy przed rozpoczęciem procesów sortowania
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(numbers);

        // Wywołanie metody sortującej przekazując naszą tablicę
        BubbleSort(numbers);

        // Wyświetlenie posortowanej tablicy
        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(numbers);
    }

    // Metoda realizująca algorytm sortowania bąbelkowego
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length; // Pobranie długości przekazanej tablicy

        // Pętla zewnętrzna - odpowiada za liczbę przejść przez całą tablicę
        for (int i = 0; i < n - 1; i++)
        {
            // Pętla wewnętrzna - porównuje sąsiadujące ze sobą elementy
            for (int j = 0; j < n - i - 1; j++)
            {
                // Sprawdzenie, czy element po lewej jest większy od elementu po prawej
                if (arr[j] > arr[j + 1])
                {
                    // Jeśli tak, zamieniamy je miejscami za pomocą funkcji pomocniczej Swap
                    Swap(arr, j, j + 1);
                }
            }
        }
    }

    // Metoda pomocnicza do zamiany miejscami dwóch elementów w tablicy
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i]; // Zapisanie wartości pierwszego elementu w zmiennej tymczasowej
        arr[i] = arr[j];   // Przypisanie wartości drugiego elementu w miejsce pierwszego
        arr[j] = temp;     // Przypisanie zapamiętanej wartości ze zmiennej tymczasowej do drugiego elementu
    }

    // Metoda pomocnicza do wypisywania elementów tablicy w konsoli
    static void PrintArray(int[] arr)
    {
        // Pętla iterująca po każdym elemencie tablicy
        foreach (var item in arr)
        {
            Console.Write(item + " "); // Wyświetlenie elementu ze spacją
        }
        Console.WriteLine(); // Prjście do nowej linii po wyświetleniu całej tablicy
    }
}