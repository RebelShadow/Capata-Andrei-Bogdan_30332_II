using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("0. Terminate");
            Console.WriteLine("1. Fibonacci");
            Console.WriteLine("2. Calculator");
            Console.WriteLine("3. C/F converter");
            Console.WriteLine("4. Ideal Weight Calculator");
            Console.WriteLine("5. Means");

            int choice=int.Parse(Console.ReadLine());

            do
            {

                switch (choice)
                {
                    case 1:
                        Fibonacci();
                        break;

                    case 2:
                        Calculator();
                        break;

                    case 3:
                        TemperatureConverter.Conversion();
                        break;

                    case 4:
                        IdealWeightCalculator.Calculate();
                        break;

                    case 5:
                        Mean();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select an option from 0 to 5.");
                        break;
                }
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("0. Terminate");
                Console.WriteLine("1. Fibonacci");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. C/F converter");
                Console.WriteLine("4. Ideal Weight Calculator");
                Console.WriteLine("5. Means");
                Console.Read();

                choice = int.Parse(Console.ReadLine());
            }while(choice != 0);
            

        }

        static void Fibonacci()
        {
            int n = 0, a = 0, b = 1;
            Console.WriteLine("Enter the value of n:");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + ", ");
                int temp = a;
                a = b;
                b += temp;
            }
            Console.Read ();

        }

        static void Calculator()
        {
            string choice = "+";
            int a = 0;
            int b = 0;
            Console.WriteLine("First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Operation (+,-,/,*)");
            choice = Console.ReadLine();
            Console.WriteLine("Second number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + choice + b + "= ");
            switch (choice)
            {
                case "+": Console.Write(a + b); break;
                case "-": Console.Write(a - b); break;
                case "/": Console.Write(a / b); break;
                case "*": Console.Write(a * b); break;


                default: Console.Write("NOT DEFINED"); break;
            }
            Console.Read();
        }

        static void Mean()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            double product = 1;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());

                product *= numbers[i];

                sum += numbers[i];
            }

            double geometricMean = Math.Pow(product, 1 / n);

            double arithmeticMean = sum / n;

            Console.WriteLine("Geometric mean: " + geometricMean);
            Console.WriteLine("Arithmetic mean: " + arithmeticMean);
            Console.Read();
        }

    }
    class TemperatureConverter
    {
        private static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static void Conversion()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");

            int choice = 0;

            choice = int.Parse(Console.ReadLine());

            double inputValue;
            string inputUnit, outputUnit;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    inputValue = double.Parse(Console.ReadLine());
                    Console.WriteLine(inputValue.ToString() + "°F is approximately " + FahrenheitToCelsius(inputValue) + "°C");
                    break;

                case 2:
                    Console.Write("Enter temperature in Celsius: ");
                    inputValue = double.Parse(Console.ReadLine());
                    Console.WriteLine(inputValue.ToString() + "°C is approximately " + CelsiusToFahrenheit(inputValue) + "°F");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1 or 2.");
                    break;
            }
            Console.Read();
        }


    }

    class IdealWeightCalculator
    {
        private static double CalculateIdealWeightForMen(double heightCm, int ageYears)
        {
            return (heightCm - 100 - ((heightCm - 150) / 4)) + ((ageYears - 20) / 4);
        }

        private static double CalculateIdealWeightForWomen(double heightCm, int ageYears)
        {
            return (heightCm - 100 - ((heightCm - 150) / 2.5)) + ((ageYears - 20) / 6);
        }

        private static void DisplayIdealWeight(double idealWeightForMen, double idealWeightForWomen, string gender)
        {
            if (gender == "m")
                Console.WriteLine("Ideal weight for men: " + idealWeightForMen + "kg");
            if (gender == "f")
                Console.WriteLine("Ideal weight for women: " + idealWeightForWomen + "kg");
        }

        public static void Calculate()
        {
            Console.Write("Enter height (in cm): ");
            double heightCm = double.Parse(Console.ReadLine());

            Console.Write("Enter age (in years): ");
            int ageYears = int.Parse(Console.ReadLine());

            Console.Write("Enter gender (f for female or m for male): ");
            string gender = Console.ReadLine();

            double idealWeightForMen = CalculateIdealWeightForMen(heightCm, ageYears);
            double idealWeightForWomen = CalculateIdealWeightForWomen(heightCm, ageYears);

            switch (gender)
            {
                case "m":
                    DisplayIdealWeight(idealWeightForMen, idealWeightForWomen, "m");
                    break;

                case "f":
                    DisplayIdealWeight(idealWeightForWomen, idealWeightForMen, "f");
                    break;

                default:
                    Console.WriteLine("Invalid gender. Please use f for female or m for male.");
                    break;
            }
            Console.Read();
        }
        
    }

}

