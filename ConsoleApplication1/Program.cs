using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static int ImputNat()//Ввод натуральных чисел
        {
            bool rightValue;
            int value;

            do
            {
                string userImput = Console.ReadLine();
                rightValue = int.TryParse(userImput, out value);
                if (value < 1) rightValue = false;
                if (!rightValue) Console.Write(@"Ожидалось число. Повторите ввод - ");
            }
            while (!rightValue);

            return value;
        }

        public static double ImputDouble()//Ввод рациональных чисел
        {
            bool rightValue;
            double value;

            do
            {
                string userImput = Console.ReadLine();
                rightValue = double.TryParse(userImput, out value);
                if (!rightValue) Console.Write(@"Ожидалось число. Повторите ввод - ");
            }
            while (!rightValue);

            return value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк: ");
            int n = ImputNat();

            Console.WriteLine("Введите число х: ");
            double x = ImputDouble();

            double[,] m = new double[n, 2 * n];
            double a;
            Random r = new Random(0);

            for (int i = 0; i < n; i++)//Заполнение матрицы чисел
                for (int j = 0; j < 2 * n; j++)
                {
                    a = r.Next(-100,100);
                    m[i, j] = a;
                }

            Console.WriteLine("Матрица чисел: ");//Вывод матрицы чисел

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }

            int[] b = new int[n];

            for (int i = 0; i < n; i++)//Получение матрицы рез-ов
            {
                b[i] = 1;
                for (int j = 0; j < 2 * n; j++)
                    if (m[i, j] > x)
                        b[i] = 0;
            }

            Console.WriteLine("Матрица результатов: ");//Вывод матрицы рез-ов

            for (int i = 0; i < n; i++)
                Console.Write(b[i] + " ");

            Console.ReadLine();
        }
    }
}
