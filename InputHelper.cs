public static class InputHelper
{
    public static int ReadInt(string message, int min, int max)
    {
        int value;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out value))
            {
                if (value >= min && value <= max)
                {
                    return value;
                }
            }
            Console.WriteLine($"Ошибка! Введите число от {min} до {max}");
        }
    }
}