using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите квадратное уравнение:");

            Console.WriteLine("Введите число a: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c: ");
            var c = int.Parse(Console.ReadLine());
             
            var DisResult = (Math.Pow(b, 2) - 4 * a * c);

            if (DisResult < 0)
            {
                throw new Exception("Некоректная запись!");
            }
            else if(a == 0 || b == 0 || c == 0)
            {
                throw new Exception("Некоректная запись!");
            }
            
            

            Console.WriteLine("Дискриминант = " + DisResult);

            double x1;
            double x2;

            var TwoMultiplyA = 2 * a;

            if(a == 0)
            {
                throw new Exception("На ноль делить нельзя!!!");
            }

            if (DisResult == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                
                x1 = (-b + Math.Sqrt(DisResult)) / TwoMultiplyA;
                x2 = (-b - Math.Sqrt(DisResult)) / TwoMultiplyA;
            }

            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");

        }  

        

    }
}
