using System;

namespace chuyendoitiente;


 class Program
{
    private static void Main(string[] args)
    {
        uint Do, Vn;
        Console.WriteLine("USD:");
        Do = uint.Parse(Console.ReadLine());
        Console.WriteLine("Vnd:" + Do*23000);

}
}