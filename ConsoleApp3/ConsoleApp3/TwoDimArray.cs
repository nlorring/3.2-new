using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    sealed class TwoDimArray : ArrayBase
    {
        int[,] array;
        int c;


        public TwoDimArray(bool user, int n, int c) : base(user, n)
        {
            this.c = c;
            array = new int[n, c];
            if (user == true)
            {
                UserCreate();
            }
            else
            {
                RndCreate();
            }
        }

        protected override void UserCreate()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + "X: " + j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        protected override void RndCreate()
        {
            Random rnd = new Random();
            array = new int[n, c];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    int r = rnd.Next(1, 200);
                    array.SetValue(r, i, j);
                }
            }
        }

        public override decimal Average()
        {
            int[,] l = array;
            decimal summ = 0;
            decimal sred = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    summ += array[i, j];
                    int len = l.Length;
                    sred = summ / len;
                }
            }
            return sred;
        }

        public override void Print()
        {
            Console.WriteLine("Двухмерный массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Y: " + i + "X: " + j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


    }
}
