using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            Factor(n);
            Console.ReadKey();
        }
        static void Fac(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }
        static async void Factor( int n)
        {
            await Task.Run(() => Fac(n));
        }
    }
}
