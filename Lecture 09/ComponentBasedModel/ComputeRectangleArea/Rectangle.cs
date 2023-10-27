namespace ComputeRectangleArea
{
    public class Rectangle
    {
        //Definisi class attrbutes
        private double panjang;
        private double lebar;

        //Constructor
        public Rectangle(double length, double width)
        {
            panjang = length;
            lebar = width;
        }

        //Fungsi untuk menghitung luas persegi panjang
        public double CalculateArea()
        {
            double luasPersegiPanjang;
            luasPersegiPanjang = panjang * lebar;
            return luasPersegiPanjang;
        }
    }
}