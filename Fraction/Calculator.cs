using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fraction
{
    internal class Calculator
    {
        private int integer { get; set; } // целое
        private int numerator { get; set; } // числитель
        private int denominator { get; set; } // знаменатель

        // constructor
        public Calculator()
        {
            integer = 0;
            numerator = 0;
            denominator = 0;
            Console.WriteLine($"Constructor default:\t\t {GetHashCode()}");
        }

        public Calculator(int integer)
        {
            this.integer = integer;
            numerator = 0;
            denominator = 0;
            Console.WriteLine($"Constructor first:\t\t {GetHashCode()}");
        }

        public Calculator(int numerator, int denominator)
        {
            integer = 0;
            this.numerator = numerator;
            if (denominator == 0) this.denominator = 1;
            else this.denominator = denominator;

            Console.WriteLine($"Constructor second:\t\t {GetHashCode()}");
        }
        public Calculator(int integer, int numerator, int denominator)
        {
            this.integer = integer;
            this.numerator = numerator;
            if (denominator == 0) this.denominator = 1;
            else this.denominator = denominator;
            Console.WriteLine($"Constructor therd:\t\t {GetHashCode()}");
        }

        public Calculator(ref Calculator other)
        {
            this.integer = other.integer;
            this.numerator = other.numerator;
            this.denominator = other.denominator;
            Console.WriteLine($"Copy Constructor:\t\t {GetHashCode()}");
        }

        // destructor
        ~Calculator()
        {
            Console.WriteLine($"Destructor:\t\t {GetHashCode()}");
        }

        // operators 

        public static bool operator ==(Calculator left, Calculator right) 
        {
            left.to_wrong();
            right.to_wrong();
            return left.numerator == right.numerator && left.denominator == right.denominator;
        }
        public static bool operator !=(Calculator left, Calculator right)
        {
            left.to_wrong();
            right.to_wrong();
            return left.numerator != right.numerator || left.denominator != right.denominator;
        }

        public static bool operator >(Calculator left, Calculator right)
        {
            left.to_wrong();
            right.to_wrong();
            return left.numerator * right.denominator > left.denominator * right.numerator;
        }

        public static bool operator <(Calculator left, Calculator right)
        {
            left.to_wrong();
            right.to_wrong();
            return left.numerator * right.denominator < left.denominator * right.numerator;
        }
        public static bool operator >=(Calculator left, Calculator right)
        {
            return !(left < right);
            
        }
        public static bool operator <=(Calculator left, Calculator right)
        {
            return !(left > right);
            
        }

        public static Calculator operator ++(Calculator other) // инкремент ++ 
        {
            if (other.integer > 0) other.integer++;
            if (other.numerator > 0) other.numerator++;
            if (other.denominator > 0) other.denominator++;
            return other;
        }

        public static Calculator operator --(Calculator other) // декремент --
        {
            if (other.integer > 0) other.integer--;
            if (other.numerator > 0) other.numerator--;
            if (other.denominator > 0) other.denominator--;
            return other;
        }


        // methods
        public void print()
        {
            if (integer > 0) { Console.Write($"{integer}"); }
            if (numerator > 0)
            {
                if (integer > 0) { Console.Write("("); }
                Console.Write($"{numerator} / {denominator}");
                if (integer > 0) { Console.Write(")"); }


            }
            else if (integer == 0)
            {
                Console.Write("0");
            }
            Console.WriteLine();

        }

        public void to_wrong() // смешанную в неправильную
        {
            numerator += integer * denominator;
            integer = 0;
        }

        public Calculator to_mixed() // неправильную в смешанную 
        {
            integer += numerator / denominator;
            numerator %= denominator;
            return this;
        }

        public void to_swap(ref Calculator left, ref Calculator right) // можно поменять два обьекта местами
        {
            Calculator temp = left;
            left = right;
            right = temp;
        }

        public void swap(ref int value1, ref int value2) // меняет 2 значения (не работает )
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }

        public Calculator to_invert() // не работает 
        {
            Calculator invert = this;
            invert.to_wrong();
            int numerator = invert.numerator;
            int denominator = invert.denominator;
            swap(ref numerator, ref denominator);
            return invert;
        }
        

        
    };

}