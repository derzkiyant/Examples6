Console.Clear();


Task41();
// Console.ReadKey();



void Task41()
{
    Console.WriteLine("\nЗадача 41: Пользователь вводит с клавиатуры M чисел. " +
                        "Посчитайте, сколько чисел больше 0 ввёл пользователь.\nПримеры:" +
                        "\n0, 7, 8, -2, -2 -> 2\n1, -7, 567, 89, 223-> 3");

    Console.WriteLine("Вводите числа c клавиатуры. Чтобы остановить ввод, введите No или пустой ввод (null)");

    List<int> dinArray = new List<int>();
    string answer = String.Empty;

    for (; answer != "No" || answer != null;)
    {
        answer = Console.ReadLine();
        dinArray.Add(Convert.ToInt32(answer));
    }







}










int ReadIntFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
