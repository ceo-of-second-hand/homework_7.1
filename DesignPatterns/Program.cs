using System;
using DesignPatterns.FactoryMethodExample;
using DesignPatterns.CompositeExample;

namespace DesignPatterns.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            RunFactoryMethodExample();
            Console.WriteLine("\n-------------------------------\n");
            RunCompositeExample();

            Console.ReadKey();
        }

        static void RunFactoryMethodExample()
        {
            Console.WriteLine("Приклад: Factory Method (Видання книг)\n");

            PublishingHouse publisher = new PrintedBookPublisher();
            Book book = publisher.PublishBook();
            book.Display();
            Console.WriteLine($"Ціна: {book.GetPrice()} грн\n");

            publisher = new EBookPublisher();
            book = publisher.PublishBook();
            book.Display();
            Console.WriteLine($"Ціна: {book.GetPrice()} грн\n");
        }

        static void RunCompositeExample()
        {
            Console.WriteLine("Приклад: Composite (Меню ресторану з цінами)\n");

            Category mainMenu = new Category("Головне меню");

            Category soups = new Category("Перші страви");
            soups.Add(new Dish("Борщ", 120.00m));
            soups.Add(new Dish("Солянка", 140.00m));

            Category drinks = new Category("Напої");
            drinks.Add(new Dish("Узвар", 50.00m));
            drinks.Add(new Dish("Морс", 45.00m));

            Category desserts = new Category("Десерти");
            desserts.Add(new Dish("Сирник", 80.00m));
            desserts.Add(new Dish("Торт Київський", 200.00m));

            mainMenu.Add(soups);
            mainMenu.Add(drinks);
            mainMenu.Add(desserts);

            mainMenu.Display(1);

            Console.WriteLine($"\nЗагальна вартість меню: {mainMenu.GetPrice()} грн");
        }
    }
}
