using System;

class Program
{
    static Tuple<double, double> TinhChuViDienTich(double canh1, double canh2)
    {
        double chuVi = 2 * (canh1 + canh2);
        double dienTich = canh1 * canh2;

        return Tuple.Create(chuVi, dienTich);
    }

    static double tinhChieuRong(double canh1, double canh2)
    {
        return Math.Min(canh1, canh2);
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap canh 1: ");
        double canh1 = double.Parse(Console.ReadLine());

        Console.Write("Nhap canh 2: ");
        double canh2 = double.Parse(Console.ReadLine());

        Tuple<double, double> chuViDienTich = TinhChuViDienTich(canh1, canh2);
        double chieurong = tinhChieuRong(canh1, canh2);

        Console.WriteLine("Chu vi: " + chuViDienTich.Item1);
        Console.WriteLine("Dien tich: " + chuViDienTich.Item2);
        Console.WriteLine("Chieu Rong: " + chieurong);

        Console.ReadLine();
    }
}
