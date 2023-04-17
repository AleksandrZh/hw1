namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, p, S;
            Console.WriteLine("Input perimeter:");
            double perimeter = double.Parse(Console.ReadLine());
            a = perimeter / 3; //исходя из условия треугольник равносторонний
            p = perimeter / 2;

            S = Math.Sqrt(p * Math.Pow((p - a), 3));

            // Console.WriteLine($"Сторона  Площадь");
            // Console.WriteLine($"  {a}      {S:F2}");

            Console.WriteLine("{0,-10}{1,10}", "Сторона", "Площадь");
            Console.WriteLine("{0,-10:F2}{1,10:F2}", a, S);

        }
    }
}