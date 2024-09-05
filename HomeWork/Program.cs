using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.miniCalculator();
            //Program.chess();

            Program.Geometri(5);

        }
        static public void chess() // big-simple-chess
        {
            Console.Write($"Введите кол-во клеток = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n * n; i++) // вертикаль
            {
                for (int f = 0; f < n * n; f++) // горизонталь 
                {
                    if (((f / n) + (i / n)) % 2 == 0)   //
                        Console.Write("* ");
                    else
                        Console.Write("  ");

                }
                Console.WriteLine();
            }
        }

        static public void miniCalculator()
        {
            double a, b;
            char[] operators = {'+', '-', '*', '/' };

            Console.Write("первое значение = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("второе значение = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("+, -, *, / введите оператор = ");
            char point = Convert.ToChar(Console.ReadLine());
            if (Array.Exists(operators, op => op == point))
            {
                double result = 0;
                switch (point)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                        case '/':
                        if (b != 0) result = a / b;
                        else Console.WriteLine("на ноль нельзя делить");
                        break;
                    default: Console.WriteLine("невозможно"); 
                        break; 
                }
                Console.WriteLine(result);
            }
        }

        static public void Geometri(int value)
        {
            Console.WriteLine("0) ");
            for (int i = 0; i < value; i++) // square 0
            {
                Console.WriteLine("*****");
            }

            Console.WriteLine("\n1) ");
            for (int i = 1; i <= value; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n2) ");
            for (int i = value; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n3) ");
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = value; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n4) ");
            for (int i = 0; i <= value; i++)
            {
                for (int j = value; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n5) ");
            // верхняя ромба 
            for (int i = 0; i <= value; i++)
            {
                for (int j = value; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int k = 0; k < (i - 1) * 2 + 2; k++)
                {
                    Console.Write(" ");
                }
                if (i > -1)
                {
                    Console.Write("\\");
                }
                Console.WriteLine();
            }
            // Нижняя половина ромба
            for (int i = value; i >= 0; i--)
            {
                for (int j = value; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                for (int k = 0; k < (i) * 2; k++)
                {
                    Console.Write(" ");
                }
                if (i > -1)
                {
                    Console.Write("/");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n6) ");
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

