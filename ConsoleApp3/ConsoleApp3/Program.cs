using ConsoleApp3;
using System;

namespace Program;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите true если хотите ввод с клавиатуры, если хотите с помощью рандома, напишите false");
        bool user = bool.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество элементов в одномерной массиве");
        int n = int.Parse(Console.ReadLine());
        OneDimArray array = new OneDimArray(user, n);
        decimal s = array.Average();
        Console.WriteLine($"Среднее кол-во элементов в массиве: {s}");

        Console.WriteLine("Без повторов:");
        array.DeleteSame();
        array.Print();

        Console.WriteLine("Массив без чисел больше 100:");
        array.DeleteAbs();
        array.Print();


        Console.WriteLine("Введите количество строк в двухмерном массиве");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в двухмерном массиве");
        int c = int.Parse(Console.ReadLine());
        TwoDimArray array2 = new TwoDimArray(user, n2, c);
        decimal s2 = array2.Average();
        Console.WriteLine($"Среднее кол-во элементов в двухмерном массиве: {s2}");

        Console.WriteLine("Введите количество строк в ступенчатом массиве");
        int n3 = int.Parse(Console.ReadLine());
        ThreeDimArray array3 = new ThreeDimArray(user, n3);
        decimal s3 = array3.Average();
        Console.WriteLine($"Среднее кол-во элементов в ступенчатом массиве: {s3}");
        array3.change();
        array3.Print();
    }
}