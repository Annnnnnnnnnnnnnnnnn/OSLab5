using System;

namespace lab5OS
{
    class Program
    {
        public static void ShowMatrix(int[,] m)
        {
            for (int i = 0; i < 100; i++)
            {

                for (int j = 0; j < 100; j++)
                {
                    Console.Write( m[i, j] + " ");
                }
                Console.WriteLine();
            }
           
        }

        public static void CreateMatrix(int[,] m)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {

                for (int j = 0; j < 100; j++)
                {
                    m[i, j] = random.Next(0,5);
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] a = new int[100, 100];
            CreateMatrix(a);
            Console.WriteLine("Начальная матрица: ");
            ShowMatrix(a);
            

            Console.WriteLine();
            long ellapledTicks = DateTime.Now.Ticks;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                   a[j,i]++;
                }
            }
            long ellapledTicks2 = DateTime.Now.Ticks - ellapledTicks;
            Console.WriteLine("Потрачено тактов на выполнение не оптимизированого кода: " + ellapledTicks2);
            Console.WriteLine("Модифицирована матрица 1 способом: ");
            ShowMatrix(a);
            long ellapledTicksF = DateTime.Now.Ticks;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    a[i,j]++;
                }
            }
            long ellapledTicksF2 = DateTime.Now.Ticks - ellapledTicks;
            Console.WriteLine("Потрачено тактов на выполнение оптимизированого кода: " + ellapledTicksF2);
            Console.WriteLine("Модифицирована матрица 2 способом: ");
            ShowMatrix(a);
        }


    }
}
