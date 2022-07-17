// Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов (значение элементов от 1 до 40)
// и выводит на экран массив квадратов этих чисел

namespace Homework29
{
    class Programe
    {
        public static void Main()
        {
            int[] array = new int[new Random().Next(5,11)];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintSquareArray(array);
            PrintArray(array);
        }
        public static void PrintArray(int[] array)
        {
        for(int i = 0; i < array.GetLength(0); i++)
            {
            Console.Write($"{array[i]} ");
            }
        Console.WriteLine();   
        } 
        public static void FillArray(int[] array)
        {
        for(int i = 0; i < array.GetLength(0); i++)
            {
            array[i] = new Random().Next(1, 41);
            }
        Console.WriteLine();   
        } 
        public static void PrintSquareArray(int[] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
            array[i] = array[i] * array[i];
            }
            Console.WriteLine();
        }

    }
}    