using System;
using Xunit; // Importujemy bibliotekę xUnit do uruchamiania testów

public class BubbleSortTests
{
    // --- TESTY POZYTYWNE ---

    [Fact] // Informacja dla xUnit, że to jest test
    public void Test_ValidArray_SortsCorrectly()
    {
        // Sprawdzamy czy metoda poprawnie sortuje zwykłą tablicę
        int[] input = { 3, 1, 2 };

        Program.BubbleSort(input);

        // Wynik po sortowaniu ma wynosić [1, 2, 3]
        Assert.Equal(new[] { 1, 2, 3 }, input);
    }

    [Fact]
    public void Test_NullArray_HandlesGracefully()
    {
        // Sprawdzamy czy program nie wywali się przy wartości null
        int[]? input = null;

        Program.BubbleSort(input);

        // Zmienna nadal powinna wynosić null
        Assert.Null(input);
    }

    [Fact]
    public void Test_EmptyArray_HandlesGracefully()
    {
        // Sprawdzamy czy program poprawnie obsługuje pustą tablicę
        int[] input = { };

        Program.BubbleSort(input);

        // Tablica nadal powinna być pusta
        Assert.Empty(input);
    }

    // --- TEST NEGATYWNY ---

    [Fact]
    public void Test_TooLargeArray_ThrowsArgumentException()
    {
        // Podajemy za dużą tablicę (ponad 1000 elementów)
        int[] tooLargeArray = new int[1001];

        // Sprawdzamy czy algorytm wyrzuci oczekiwany błąd (ArgumentException)
        Assert.Throws<ArgumentException>(() => Program.BubbleSort(tooLargeArray));
    }
}