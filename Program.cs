// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    { 
        int x =Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x-Math.Pow(Math.Sin(x),10)+Math.Cos(x-y));
    }
}