using System;

public class Play : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    // Конструктор класу
    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    // Метод для відображення інформації про п'єсу
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Year: {Year}");
    }

    // Реалізація інтерфейсу IDisposable
    public void Dispose()
    {
        // Логіка для вивільнення ресурсів, якщо потрібно
        Console.WriteLine($"Play {Title} by {Author} is disposed.");
    }
}

public enum ShopType
{
    Grocery,
    Household,
    Clothing,
    Footwear
}

public class Shop : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public ShopType Type { get; set; }

    // Конструктор класу
    public Shop(string name, string address, ShopType type)
    {
        Name = name;
        Address = address;
        Type = type;
    }

    // Метод для відображення інформації про магазин
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Type: {Type}");
    }

    // Реалізація інтерфейсу IDisposable
    public void Dispose()
    {
        // Логіка для вивільнення ресурсів, якщо потрібно
        Console.WriteLine($"Shop {Name} is disposed.");
    }

    // Деструктор
    ~Shop()
    {
        // Логіка для деструктора, якщо потрібно
        Console.WriteLine($"Shop {Name} is being finalized.");
    }
}

class Program
{
    static void Main()
    {
        // Перше завдання: використання класу Play з інтерфейсом IDisposable
        using (var play = new Play("Romeo and Juliet", "William Shakespeare", "Tragedy", 1597))
        {
            play.DisplayInfo();
        } // При завершенні блоку using викликається метод Dispose для класу Play

        Console.WriteLine();

        // Друге завдання: використання класу Shop з інтерфейсом IDisposable та деструктором
        using (var shop = new Shop("My Shop", "123 Main St", ShopType.Grocery))
        {
            shop.DisplayInfo();
        } // При завершенні блоку using викликається метод Dispose для класу Shop та його деструктор
    }
}
