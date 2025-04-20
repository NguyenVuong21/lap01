//bai01
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhap ten cua ban: ");
//        string name = Console.ReadLine();
//        Console.Write("Nhap tuoi cua ban: ");
//        int age = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Xin chao {name}, Ban {age} tuoi!");
//    }
//}

//bai02
//using System;

//internal class Program
//{
//    private static void Main(string[] args)    {
//Console.Write("Nhap chieu dai: ");
//        double length = double.Parse(Console.ReadLine());
//        Console.Write("Nhap chieu reong: ");
//        double width = double.Parse(Console.ReadLine());
//        double area = length * width;
//        Console.WriteLine($"dien tich HCN la: {area}");
//    }
//}

//bai03
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//{
//    Console.Write("Nhap nhiet do (do C): ");
//        double celsius = double.Parse(Console.ReadLine());
//        double fahrenheit = (celsius * 9 / 5) + 32;
//        Console.WriteLine($"{celsius} do C = {fahrenheit} do F");
//    }
//}

//bai 04
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//{
//    Console.Write("Nhap 1 so nguyen: ");
//        int number = int.Parse(Console.ReadLine());
//        if (number % 2 == 0)
//        {
//            Console.WriteLine($"{number} la so chan.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} khong phai la so chan.");
//        }
//    }
//}

//bai 05
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//{
//    Console.Write("Nhap so thu nhat: ");
//        double num1 = double.Parse(Console.ReadLine());
//        Console.Write("Nhap so thu 2: ");
//        double num2 = double.Parse(Console.ReadLine());
//        double sum = num1 + num2;
//        double product = num1 * num2;
//        Console.WriteLine($"Tong: {sum}, Tich: {product}");
//    }
//}

//bai06
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        {
//            Console.Write("Nhap mot so: ");
//            double number = double.Parse(Console.ReadLine());
//            if (number > 0)
//            {
//                Console.WriteLine("So duong.");
//            }
//            else if (number < 0)
//            {
//                Console.WriteLine("So am.");
//            }
//            else
//            {
//                Console.WriteLine("So khong.");
//            }
//        }
//    }
//}

//bao07
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhap 1 nam: ");
//        int year = int.Parse(Console.ReadLine());
//        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
//        if (isLeapYear)
//        {
//            Console.WriteLine($"{year} la nam nhuan.");
//        }
//        else
//        {
//            Console.WriteLine($"{year} khong phai nam nhuan.");
//        }
//    }
//}

//bao08
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//{
//    for (int i = 1; i <= 10; i++)
//        {
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.WriteLine($"{i} x {j} = {i * j}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//bai09
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//{
//    Console.Write("Nhap so nguyen duong n: ");
//        int n = int.Parse(Console.ReadLine());
//        long factorial = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            factorial *= i;
//        }
//        Console.WriteLine($"{n}! = {factorial}");
//    }
//}

//bai10
//using System;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhap mot so nguyen duong: ");
//        int number = int.Parse(Console.ReadLine());
//        bool isPrime = true;
//        if (number < 2)
//        {
//            isPrime = false;
//        }
//        else
//        {
//            for (int i = 2; i <= Math.Sqrt(number); i++)
//            {
//                if (number % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//        }
//        if (isPrime)
//        {
//            Console.WriteLine($"{number} la so nguyen to.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} khong phai so nguyen to.");
//        }
//    }
//}