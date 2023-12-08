

using System;

namespace toantucoban;

 class Program
{
    private static void Main(string[] args)
    {
        float cao, rong;
        Console.WriteLine("S HCN");
        Console.WriteLine("Nhap chieu cao vao nhanh: ");
        cao = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong vao mau: ");
        rong = float.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hcn la: " + cao*rong);



        }
}
