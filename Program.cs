using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] mas = new double[3];
            char[] ch = new char[3] { 'a', 'b', 'c' };
            bool tr;
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.Write("Введите коэффицент  " + ch[i] + "\n");
                    string line = Console.ReadLine();
                    tr = Double.TryParse(line, out mas[i]);

                } while (!tr);
            }
            double a = mas[0], b = mas[1], c = mas[2];
            double D = b * b - 4 * a * c;
            if (D < 0) { Console.WriteLine("корней нет"); }
            else
            {
                D = Math.Sqrt(D);
                if (D == 0)
                {
                    Console.WriteLine("один корень равный " + (-1 * b + D) / (2 * a));
                }
                else
                {
                    Console.WriteLine("два корня  равные " + (-1 * b + D) / (2 * a) + "  и  " + (-1 * b - D) / (2 * a));
                }
            }
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();

        }
    }

}