using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Найкращі книги:");

        // Створення масиву книг
        string[] books = new string[]
        {
            "Війна і мир",
            "1984",
            "Гаррі Поттер і філософський камінь",
            "Улисс",
            "Майстер і Маргарита",
            "Таємниця старого замку",
            "Сто років самотності",
            "Вітер у вербах",
            "Мертві душі",
            "Три товариші"
        };

        // Виведення списку книг на екран
        foreach (string book in books)
        {
            Console.WriteLine("- " + book);
        }

        Console.ReadLine();
    }
}
