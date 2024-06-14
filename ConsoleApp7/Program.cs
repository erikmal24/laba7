using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[20];
            Console.Write("Введите число элементов массива n =");
            int n = Convert.ToInt32(Console.ReadLine());


            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                m[i] = rnd.Next(1, 20);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("m[" + (i + 1) + "] =" + m[i]);
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] < 18)
                { s += m[i]; }
            }
            Console.WriteLine($"Сумма элементов массива m, меньших 18 и расположенных на четных позициях: ={s}");
            int[] f = new int[20];
            for (int i = 0; i < 20; i++)
            {
                f[i] = m[i] + 8;
                Console.WriteLine($"Элемент f[{i + 1}]: {f[i]}");
            }
            Console.WriteLine();

            int proiz = 1;
            int nulev = 0;
            for (int i = 0; i < 20; i++)
            {
                if (f[i] > 0)
                    proiz *= f[i];
                else if (f[i] == 0)
                    nulev++;
            }
            Console.WriteLine($"Произведение положительных элементов массива f: {proiz}");
            Console.WriteLine($"Количество нулевых элементов массива f: {nulev}");
        }
    }
}
