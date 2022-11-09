using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinerEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите квадратное уравнение:");
          
            int a = NameParameter("a");
            int b = NameParameter("b");
            int c = NameParameter("c");

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("-1");
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("0");
            }
            else if (a == 0)
            {
                Console.WriteLine("1" + -c / b);
            }
            var DisResult = (Math.Pow(b, 2) - 4 * a * c);

            double x0 = 0;
            double x1 = 0;
            double x2 = 0;

            var TwoMultiplyA = 2 * a;

            if(TwoMultiplyA == 0)
            {
                throw new Exception("Делить на ноль нельзя!");
            }

            Console.WriteLine("Дискриминант = " + DisResult);
            
            
            if (DisResult < 0)
            {
                throw new Exception("Нет корней!");
            }
            if (DisResult == 0)
            {
                Console.WriteLine(x0 = -b / (2 * a));
                Console.WriteLine($"x0 = {x0}");
            }
            else if (DisResult > 0)
            {
                x1 = (-b + Math.Sqrt(DisResult)) / TwoMultiplyA;
                x2 = (-b - Math.Sqrt(DisResult)) / TwoMultiplyA;
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
        }

        static public int NameParameter(string name)
        {
            Console.Write($"Введите значение {name}\t");

            if (!int.TryParse(Console.ReadLine(), out var variable))       
            {
                throw new Exception($"Значение {name} некоректное" + "\tнапишите цифру!");
                
            }

            return variable;
        }
    }
   
}
