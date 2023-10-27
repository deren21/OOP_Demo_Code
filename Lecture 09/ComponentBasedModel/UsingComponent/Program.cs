using ComputeRectangleArea;

class Program
{
    public static void Main()
    {
        double panjang = 15.0;
        double lebar = 10.0;
        Rectangle persegiPanjang = new Rectangle(panjang, lebar);
        double luas = persegiPanjang.CalculateArea();
        Console.WriteLine($"Luas dari persegi panjang" + $"dengan panjang {panjang} dan " + $"lebar {lebar} adalah {luas}");
        Console.ReadLine();
    }
}