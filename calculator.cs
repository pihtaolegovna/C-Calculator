using System;

int operation = 0;
Console.WriteLine("1. Прибавить");
Console.WriteLine("2. Вычесть");
Console.WriteLine("3. Умножить");
Console.WriteLine("4. Разделить");
Console.WriteLine("5. Возвести в степень");
Console.WriteLine("6. Найти квадратный корень");
Console.WriteLine("7. Найти 1% от числа");
Console.WriteLine("8. Найти факториал числа");
Console.WriteLine("9. Выйти из программы");
do
{
    bool isrunning = true;
    Console.WriteLine("Введите первое число: ");
    int value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int value2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Выберите номер операции: ");
    operation = Convert.ToInt32(Console.ReadLine());
    switch (operation)
    {
        case 1:
            Console.WriteLine($"Результат: " + (value1 + value2));
            break;
        case 2:
            Console.WriteLine($"Результат: " + (value1 - value2));
            break;
        case 3:
            Console.WriteLine($"Результат: " + (value1 * value2));
            break;
        case 4:
            Console.WriteLine($"Результат: " + (value1 / value2));
            break;
        case 5:
            int value_power = value1;
            while (isrunning == true) ;
            value_power = value_power * value1;
            value2--;
            if (value2 < 1)
                isrunning = false;
            Console.WriteLine($"Результат: " + (value_power));
            break;
        case 6:
            int sqrt_value = Convert.ToInt32(Math.Sqrt(value1));
            Console.WriteLine($"Результат: " + (sqrt_value));
            break;
        case 7:
            Console.WriteLine($"Результат: " + (value1 / 100));
            break;
        case 8:
            int i, factorial = 1;
            for (i = 1; i <= value1; i++)
                factorial = factorial * i;
            Console.WriteLine($"Результат: " + factorial);
            break;
    }
    Console.Write("Нажмите любую клавишу для перезапуска");
    Console.ReadKey();
    Console.Clear();
}
while (operation < 9);
