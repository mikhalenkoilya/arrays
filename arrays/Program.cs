Console.WriteLine("Каталог пользователей");
Console.Write("Введите количество пользователей: ");
int col = 3;
try
{
    int usersNum = int.Parse(Console.ReadLine());

    if (usersNum >= 2 && usersNum <= 5)
    {
        string[,] usersArray = new string[usersNum, col];
        for (int i = 0; i < usersNum; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < col; j++)
            {
                Console.Write($"Введите параметр {j + 1} для пользователля {i + 1}: ");
                string? data = Console.ReadLine();
                usersArray[i, j] = data;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Весь каталог");
        for (int i = 0; i < usersNum; i++)
        {
            Console.Write($"{i + 1} пользователь: ");
            for (int j = 0; j < col; j++)
            {
                Console.Write($"{usersArray[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write("Данные по какому пользователю нужны: ");
        int curUser = int.Parse(Console.ReadLine());
        try { 
            for (int i = 0; i < col; i++)
            {
                Console.Write($"{usersArray[curUser - 1, i]} ");
            }
        }
        catch
        {
            Console.WriteLine("В каталоге нет такого пользователя");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Неправильный ввод данных");
    Console.WriteLine(ex.Message);
}