using System;

// S - Single Responsibility Principle

class BookService
{
    public int GetBookId()
    {
        return 317;
    }
}

class BookDisplay
{
    public void DisplayBook(string title)
    {
        Console.WriteLine("Book Title: " + title);
    }
}


// O - Open/Closed Principle

abstract class MembershipDiscount
{
    public abstract double Calculate(double amount);
}

class RegularMemberDiscount : MembershipDiscount
{
    public override double Calculate(double amount)
    {
        return amount * 0.05; // 5% discount
    }
}

class PremiumMemberDiscount : MembershipDiscount
{
    public override double Calculate(double amount)
    {
        return amount * 0.20; // 20% discount
    }
}


// L - Liskov Substitution Principle

abstract class LibraryItem
{
    public abstract void Borrow();
}

abstract class DigitalItem : LibraryItem
{
    public abstract void Download();
}

class EBook : DigitalItem
{
    public override void Borrow()
    {
        Console.WriteLine("EBook borrowed.");
    }

    public override void Download()
    {
        Console.WriteLine("EBook downloaded.");
    }
}

class PrintedBook : LibraryItem
{
    public override void Borrow()
    {
        Console.WriteLine("Printed book borrowed.");
    }
}


// I - Interface Segregation Principle

interface IReadable
{
    void Read();
}

interface IWritable
{
    void Write();
}

class Author : IWritable
{
    public void Write()
    {
        Console.WriteLine("Author is writing a book.");
    }
}

class Reader : IReadable
{
    public void Read()
    {
        Console.WriteLine("Reader is reading a book.");
    }
}


// D - Dependency Inversion Principle

interface IStorage
{
    void Save();
}

class SQLStorage : IStorage
{
    public void Save()
    {
        Console.WriteLine("Data saved in SQL Database.");
    }
}

class CloudStorage : IStorage
{
    public void Save()
    {
        Console.WriteLine("Data saved in Cloud Storage.");
    }
}

class LibraryApplication
{
    private IStorage storage;

    public LibraryApplication(IStorage storage)
    {
        this.storage = storage;
    }

    public void SaveData()
    {
        storage.Save();
    }
}


// Main Program

class Program
{
    public static void Main(string[] args)
    {
        // SRP
        Console.WriteLine("Single Responsibility Principle.");
        BookDisplay display = new BookDisplay();
        display.DisplayBook("Clean Code");

        BookService service = new BookService();
        Console.WriteLine("Book ID: " + service.GetBookId());

        Console.WriteLine();

        // OCP
        Console.WriteLine("Open/Closed Principle.");
        MembershipDiscount premium = new PremiumMemberDiscount();
        Console.WriteLine("Premium Discount: " + premium.Calculate(1000));

        MembershipDiscount regular = new RegularMemberDiscount();
        Console.WriteLine("Regular Discount: " + regular.Calculate(1000));

        Console.WriteLine();

        // LSP
        Console.WriteLine("Liskov Substitution Principle.");
        EBook ebook = new EBook();
        ebook.Borrow();
        ebook.Download();

        PrintedBook printed = new PrintedBook();
        printed.Borrow();

        Console.WriteLine();

        // ISP
        Console.WriteLine("Interface Segregation Principle.");
        Author author = new Author();
        author.Write();

        Reader reader = new Reader();
        reader.Read();

        Console.WriteLine();

        // DIP
        Console.WriteLine("Dependency Inversion Principle.");
        IStorage sql = new SQLStorage();
        LibraryApplication app1 = new LibraryApplication(sql);
        app1.SaveData();

        IStorage cloud = new CloudStorage();
        LibraryApplication app2 = new LibraryApplication(cloud);
        app2.SaveData();
    }
}