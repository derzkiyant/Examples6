Task41();
Console.ReadKey();

Task43();


void Task41()
{
    Console.WriteLine("\nЗадача 41: Пользователь вводит с клавиатуры M чисел. " +
                        "Посчитайте, сколько чисел больше 0 ввёл пользователь.\nПримеры:" +
                        "\n0, 7, 8, -2, -2 -> 2\n1, -7, 567, 89, 223 -> 4");

    Console.WriteLine("Вводите числа c клавиатуры (чтобы остановить ввод, введите stop");

    List<int> dinArray = new List<int>();
    string answer = Console.ReadLine();

    do
    {
        dinArray.Add(Convert.ToInt32(answer));
        answer = Console.ReadLine();
    }
    while (answer != "stop");

    int count = 0;

    for (int i = 0; i < dinArray.Count; i++)
    {
        if (dinArray[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine(String.Join(", ", dinArray) + $" -> {count}");
}

void Task43()
{
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, " +
                        "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. " +
                        "Значения b1, k1, b2 и k2 задаются пользователем.\nПример:" +
                        "\nb1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");

    double b1 = ReadDoubleFromConsole("Введите b1: ");
    double k1 = ReadDoubleFromConsole("Введите k1: ");

    double b2 = ReadDoubleFromConsole("Введите b2: ");
    double k2 = ReadDoubleFromConsole("Введите k2: ");

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1; // или double y = k2 * x + b2;

    Console.WriteLine($"Точка пересечения двух прямых -> ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}


double ReadDoubleFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
