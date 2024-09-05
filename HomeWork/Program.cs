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
            Program.miniCalculator();
            Program.chess();

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
    }
}

