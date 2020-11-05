using System;

namespace uamLessons
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool status = true;

            while (status != false)
            {
                Console.WriteLine("1)Dodawanie.");
                Console.WriteLine("2)Mnozenie.");
                Console.WriteLine("3)Dzielienie.");
                Console.WriteLine("4)Potegowanie.");
                Console.WriteLine("5)Odejmowanie.");
                Console.WriteLine("6)Obliczyc silnię.");
                Console.WriteLine("--");
                Console.WriteLine("k - wyjsc!");

                string op = Console.ReadLine();

                double num1;

                if (op == "k")
                {
                    Console.Clear();
                    Console.WriteLine("Program is over!");
                    status = false;
                }
                else if (op == "6")
                {
                    Console.WriteLine("Wpisz numer: ");

                    num1 = double.Parse(Console.ReadLine());

                    double res = 0;

                    if (num1 == 0)
                    {
                        Console.WriteLine("number can not be a zero!");
                        status = false;
                    }

                    if (op == "6")
                    {
                        for (int i = 0; i <= num1; i++)
                        {
                            res += i;
                        }

                        Console.WriteLine($"result --> {res}");
                    } 
                }
                else
                {
                    Console.WriteLine("Wpisz x oraz y: ");

                    num1 = double.Parse(Console.ReadLine());
                    double num2 = double.Parse(Console.ReadLine());

                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("number can not be a zero!");
                        status = false;
                    }

                    else if (op == "1")
                    {
                        Console.WriteLine($"result --> {num1 + num2}");
                        
                    }

                    else if (op == "2")
                    {
                        Console.WriteLine($"result --> {num1 * num2}");
                    }

                    else if (op == "3")
                    {
                        Console.WriteLine($"result --> {num1 / num2}");
                    }
                    else if (op == "5")
                    {
                        Console.WriteLine($"result --> {num1 - num2}");
                    }
                    else if (op == "4")
                    {
                        Console.WriteLine($"result --> {Math.Pow(num1, num2)}" );
                    }
                }

                

            }

           




        }
    }
}