using System;

class Program
{
    static void Main()
    {
        // Задайте значения для a, b, c и d
        int a = 1;
        int b = 2;
        int c = 3;
        int d = 4;

        // Проверяем, что знаменатель не равен нулю
        if (c + d != 0)
        {
            // Вычисляем значение формулы
            double result = (double)(a * b) / (c + d);

            // Выводим результат на экран
            Console.WriteLine("Результат: " + result);
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль");
        }
    }
}
