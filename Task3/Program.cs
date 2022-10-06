using System;


namespace Task3;
internal class Program
{
    private static void Main(string[] args)
    {
        Converter converter = new(37.1m, 36.8m);
        decimal amount = 0m;
        decimal value = 0m;
        string currency = "";
        bool flag;
        bool flag2;
        bool flag3 = true;

        while (flag3)
        {
            flag = true;
            flag2 = true;
            Console.WriteLine("Input currency you have(UAH, EUR, USD, END(to finish):");
            switch (Console.ReadLine())
            {
                case "UAH":
                    while (flag2)
                    {
                        flag = true;
                        Console.WriteLine("Input currency you get(EUR, USD):");
                        currency = "" + Console.ReadLine();
                        while (flag)
                        {
                            Console.WriteLine("Input value(UAH):");
                            try
                            {
                                amount = Convert.ToDecimal(Console.ReadLine());
                                switch (currency)
                                {
                                    case "EUR":
                                        value = converter.UahToEur(amount);
                                        break;
                                    case "USD":
                                        value = converter.UahToUsd(amount);
                                        break;
                                    default:
                                        throw new ArgumentException("Currency is not valid");
                                }
                                Console.WriteLine($"You get {Math.Round(value, 2)} {currency}");
                                flag = false;
                                flag2 = false;
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                flag = false;
                            }
                            catch
                            {
                                Console.WriteLine("Input decimal value!");
                            }
                        }
                    }
                    break;
                case "EUR":
                    while (flag)
                    {
                        Console.WriteLine("Input value(EUR):");
                        try
                        {
                            amount = Convert.ToDecimal(Console.ReadLine());
                            value = converter.EurToUah(amount);
                            Console.WriteLine($"You get {Math.Round(value, 2)} EUR");
                            flag = false;
                        }
                        catch
                        {
                            Console.WriteLine("Input decimal value!");
                        }
                    }
                    break;
                case "USD":
                    while (flag)
                    {
                        Console.WriteLine("Input value(USD):");
                        try
                        {
                            amount = Convert.ToDecimal(Console.ReadLine());
                            value = converter.UsdToUah(amount);
                            Console.WriteLine($"You get {Math.Round(value, 2)} USD");
                            flag = false;
                        }
                        catch
                        {
                            Console.WriteLine("Input decimal value!");
                        }
                    }
                    break;
                case "END":
                    flag3 = false;
                    break;
                default:
                    Console.WriteLine("Currency is not valid");
                    break;
            }
        }
    }
}