// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

namespace Homework25
{
    class Programe
    {
        public static void Main()
        {
            Console.WriteLine("Ведите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = Math.Pow(a,b);
            Console.WriteLine(result);

        }
    }
}
