using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void MakeArray(int i, Lab deleg)
        {
            int[] mas = new int[i];
            mas = deleg(mas);
            foreach (var j in mas)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
        static Lab first = delegate (int[] mas)
        {
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 101);
            }
            return mas;
        };
        static Lab second = delegate (int[] mas)
        {
            int num1 = 0;
            int num2 = 1;
            int temp = 0;
            mas[0] = num1;
            for (int i = 1; i < mas.Length; i++)
            {
                mas[i] = num2;
                temp = num2;
                num2 += num1;
                num1 = temp;
            }
            return mas;
        };
        static Lab third = delegate (int[] mas)
        {
            int num = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = num;
                num += 3;
            }
            return mas;
        };
        static void Main(string[] args)
        {

            Console.WriteLine("Array 1");
            MakeArray(15, first);
            Console.WriteLine("Array 2");
            MakeArray(10, second);
            Console.WriteLine("Array 3");
            MakeArray(20, third);
        }
    }
    delegate int[] Lab(int[] mas);
}
