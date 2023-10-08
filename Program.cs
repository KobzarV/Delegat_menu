class Program
{
    delegate void MenuItem();

    static void NewGame()
    {
        Console.WriteLine("Стартуємо нову гру!");
    }

    static void LoadGame()
    {
        Console.WriteLine("Завантаження гри...");
    }

    static void ShowRules()
    {
        Console.WriteLine("Правила гри:");
    }

    static void AuthorInfo()
    {
        Console.WriteLine("Про автора:");
    }

    static void Exit()
    {
        Console.WriteLine("Ви вийшли з гри. До зустрічі!");
    }

    static void Main()
    {

        MenuItem[] menuMethods = new MenuItem[]
       {
            NewGame,
            LoadGame,
            ShowRules,
            AuthorInfo,
            Exit
       };
        Console.WriteLine("\tМеню:");
        Console.WriteLine("1) Нова гра");
        Console.WriteLine("2) Завантажити гру");
        Console.WriteLine("3) Правила");
        Console.WriteLine("4) Про автора");
        Console.WriteLine("0) Вихід");

        while (true)
        {
            Console.Write("Виберіть опцію (1-5, або 0 для виходу): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                break;
            }

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 5)
            {
                // Викликаємо відповідний метод за допомогою делегата
                menuMethods[choice - 1].Invoke();
            }
            else
            {
                Console.WriteLine("Невірний вибір. Будь ласка, введіть число від 1 до 5 або * для виходу.");
            }
        }
    }
}