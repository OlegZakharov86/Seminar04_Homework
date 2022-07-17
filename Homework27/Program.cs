// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

namespace Homework27
{
    class Programe
    {
        public static void Main()
        {
            Console.WriteLine("Введите число");
            string? str = (Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
               sum += int.Parse((str[i]).ToString());
            }
            Console.WriteLine(sum);
        }
    }
}