using System;
class Program
{
    public static void Main()
    {
        double inrAmount = Convert.ToDouble(Console.ReadLine());
        const double UsdRate = 1.22;
        const double EurRate = 1.27;
        const double CnyRate = 8.79;
        double usdAmount = inrAmount / 100 * UsdRate;
        double eurAmount = inrAmount / 100 * EurRate;
        double cnyAmount = inrAmount / 100 * CnyRate;
        usdAmount = Math.Round(usdAmount, 2);
        eurAmount = Math.Round(eurAmount, 2);
        cnyAmount = Math.Round(cnyAmount, 2);
        Console.WriteLine(usdAmount+"USD");
        Console.WriteLine(eurAmount+"EUR");
        Console.WriteLine(cnyAmount+"CNY");
    }
}

