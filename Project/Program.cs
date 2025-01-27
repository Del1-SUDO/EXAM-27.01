using System;
using ClassLibrary;
class Program
{
    static void Main()
    {
        Library library = new Library();

        library.PrintStudents();

        System.Console.WriteLine();
        library.FindStudentsByGroup("A-101");

        System.Console.WriteLine();
        library.GetAverageAge();

        System.Console.WriteLine();
        library.FindYoungest();

        System.Console.WriteLine();
        library.FilterByAge(19, 20);

        System.Console.WriteLine();
        System.Console.Write("Название книги: ");
        string Title = Console.ReadLine();
        System.Console.Write("Автор: ");
        string Author = Console.ReadLine();
        System.Console.Write("Год выпуска: ");
        int Year = int.Parse(Console.ReadLine());
        Book add = new Book (Title, Author, Year, true);
        library.AddBook(add);

        System.Console.WriteLine();
        library.FindBooksByYear(1999);

        System.Console.WriteLine();
        library.CountBooksByAuthor("Толстой");

        System.Console.WriteLine();
        library.ChangeBookStatus("Война и мир", false);
    }
}
