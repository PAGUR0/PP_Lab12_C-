using System;
using System.Collections.Generic;
using static Program;

public interface IUser
{
    string Username { get; set; }
    string Password { get; set; }
    void DisplayUser();
}

public interface IPublisher
{
    string Title { get; set; }
    string Author { get; set; }
    void DisplayDetails();
}

public interface IBook : IPublisher
{
    string PublicationDate { get; set; }
    int PageCount { get; set; }
    void DisplayBookInfo();
}

public class User : IUser
{
    public string Username { get; set; }
    public string Password { get; set; }
    public void DisplayUser()
    {
        Console.WriteLine($"Имя: {Username}, Пароль: {Password}");
    }
}



public class Book : IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }
}

public class UserBook : IBook, IUser
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public void Purchase()
    {
        Console.WriteLine($"Пользователь {Username} купил книгу \"{Title}\".");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }

    public void DisplayUser()
    {
        Console.WriteLine($"Имя: {Username}, Пароль: {Password}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book
        {
            Title = "Бесы",
            Author = "Достоевский",
            PublicationDate = "1876, 12, 12",
            PageCount = 356
        };

        Book book2 = new Book
        {
            Title = "Китайский язык",
            Author = "Хунь Чжи",
            PublicationDate = "2018, 8, 21",
            PageCount = 1000
        };

        User user1 = new User
        {
            Username = "Матвей",
            Password = "ну37"
        };

        User user2 = new User
        {
            Username = "Иван",
            Password = "37ну"
        };

        UserBook userBook1 = new UserBook
        {
            Title = book1.Title,
            Author = book1.Author,
            PublicationDate = book1.PublicationDate,
            PageCount = book1.PageCount,
            Username = user1.Username,
            Password = user1.Password
        };
        UserBook userBook2 = new UserBook
        {
            Title = book2.Title,
            Author = book2.Author,
            PublicationDate = book2.PublicationDate,
            PageCount = book2.PageCount,
            Username = user2.Username,
            Password = user2.Password
        };


        userBook1.Purchase();
        userBook1.DisplayDetails();
        userBook1.DisplayUser();

        Console.WriteLine("");

        userBook2.Purchase();
        userBook2.DisplayDetails();
        userBook2.DisplayUser();
    }
}