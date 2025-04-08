public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nГлавное меню:");
            Console.WriteLine("1 - Работа с базовым классом TripleNumbers");
            Console.WriteLine("2 - Работа с дочерним классом RgbColor");
            Console.WriteLine("0 - Выход");
            Console.Write("Введите номер действия: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WorkWithTripleNumbers();
                    break;
                case "2":
                    WorkWithRgbColor();
                    break;
                case "0":
                    Console.WriteLine("Программа завершена.");
                    return; // Завершение программы
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    private static void WorkWithTripleNumbers()
    {
        Console.WriteLine("\nРабота с базовым классом TripleNumbers:");
        int a = InputHelper.ReadInt("Введите значение A: ", int.MinValue, int.MaxValue);
        int b = InputHelper.ReadInt("Введите значение B: ", int.MinValue, int.MaxValue);
        int c = InputHelper.ReadInt("Введите значение C: ", int.MinValue, int.MaxValue);

        var numbers = new TripleNumbers(a, b, c);
        Console.WriteLine($"Создан объект: {numbers}");
        Console.WriteLine($"Произведение полей: {numbers.GetProduct()}");

        var copiedNumbers = new TripleNumbers(numbers);
        Console.WriteLine($"Копия объекта: {copiedNumbers}");
    }

    private static void WorkWithRgbColor()
    {
        Console.WriteLine("\nРабота с дочерним классом RgbColor:");

        Console.WriteLine("Цвет 1:");
        int r1 = InputHelper.ReadInt("R (0-255): ", 0, 255);
        int g1 = InputHelper.ReadInt("G (0-255): ", 0, 255);
        int b1 = InputHelper.ReadInt("B (0-255): ", 0, 255);
        var color1 = new RgbColor(r1, g1, b1);

        Console.WriteLine("\nЦвет 2:");
        int r2 = InputHelper.ReadInt("R (0-255): ", 0, 255);
        int g2 = InputHelper.ReadInt("G (0-255): ", 0, 255);
        int b2 = InputHelper.ReadInt("B (0-255): ", 0, 255);
        var color2 = new RgbColor(r2, g2, b2);

        Console.WriteLine($"\nЦвет 1: {color1}");
        Console.WriteLine($"HEX: {color1.ToHex()}");
        Console.WriteLine($"Цвет 2: {color2}");
        Console.WriteLine($"HEX: {color2.ToHex()}");

        var mixedColor = color1.MixWith(color2);
        Console.WriteLine($"Смешанный цвет: {mixedColor}");
        Console.WriteLine($"HEX: {mixedColor.ToHex()}");
    }
}
