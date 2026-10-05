using Xunit;

public class BubbleSortTests
{
    // 1. Zwykły test - poprawne sortowanie
    [Fact]
    public void Test_ValidArray()
    {
        int[] input = { 3, 1, 2 };
        Program.BubbleSort(input);
        Assert.Equal(new[] { 1, 2, 3 }, input);
    }

    // 2. Test na null - sprawdza czy program się nie wywala
    [Fact]
    public void Test_NullArray()
    {
        int[]? input = null;
        Program.BubbleSort(input);
        Assert.Null(input);
    }

    // 3. Test na pustą tablicę
    [Fact]
    public void Test_EmptyArray()
    {
        int[] input = { };
        Program.BubbleSort(input);
        Assert.Empty(input);
    }
}