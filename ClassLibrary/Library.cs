namespace ClassLibrary;
public class Library
{
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Book> Books { get; set; } = new List<Book>(); 

    public void PrintStudents()
    {
        Student add = new Student("Алексей", 20, "A-101");
        Student add2 = new Student("Мария", 19, "B-202");
        Students.Add(add);
        Students.Add(add2);

        System.Console.WriteLine("Список всех студентов: ");
        foreach (var item in Students)
        {
            System.Console.WriteLine($"Студент: {item.Name}, Возраст: {item.Age}, Группа: {item.Group}");
        }
        System.Console.WriteLine($"Всего студентов: {Students.Count()}");
    }

    public void FindStudentsByGroup(string group)
    {
        int cnt = 0;
        System.Console.WriteLine($"=== Поиск студентов группы {group} ===");
        foreach (var item in Students)
        {
            if (item.Group == group)
            {
                System.Console.Write("Найден студент: ");
                System.Console.WriteLine($"{item.Name} из группы {item.Group}");
                cnt++;
            }
        }
        System.Console.WriteLine($"Всего найдено студентов: {cnt}");
    }

    public void GetAverageAge()
    {
        float average = 0;
        foreach (var item in Students)
        {
            average += item.Age; 
        }
        average = average / Students.Count();
        System.Console.WriteLine($"Количество студентов: {Students.Count()}");
        System.Console.WriteLine($"Средний возраст: {average} лет");
    }

    public void FindYoungest(){
        Student youngest = Students[0];
        foreach (var item in Students)
        {
            if (item.Age < youngest.Age)
            {
                youngest = item;
            }
        }
        System.Console.WriteLine($"Самый молодой: {youngest.Name} ({youngest.Age})");
    }

    public void FilterByAge(int minAge, int maxAge)
    {
        int cnt = 1;
        foreach (var item in Students)
        {
            if (item.Age >= minAge && item.Age <= maxAge)
            {
                System.Console.WriteLine($"{cnt}. {item.Name}, {item.Age} лет, Группа: {item.Group}");
            }
        }
    }

    public void AddBook(Book book)
    {
        if (book.Year <= 2025 && book.Title.Count() > 3 && book.Author.Count() > 3)
        {
            Books.Add(book);
            System.Console.WriteLine($"Книга успешно добавлена");
        }
    }

    public void FindBooksByYear(int year)
    {
        Book add = new Book ("Гарри Поттер", "Роулинг", 1999, true);
        Book add2 = new Book ("Война и мир", "Толстой", 1869, true);
        Books.Add(add);
        Books.Add(add2);
        int cnt = 1;
        foreach (var item in Books)
        {
            if (item.Year == year)
            {
                System.Console.WriteLine($"{cnt}. '{item.Title}' - {item.Author}");
            }
        }
    }

    public void CountBooksByAuthor(string author)
    {
        int cnt = 0;
        int use = 1;
        foreach (var item in Books)
        {
            if (item.Author == author)
            {
                cnt++;
                System.Console.WriteLine($"Всего книг: {cnt}");
                System.Console.WriteLine($"Доступно: {cnt}");
                System.Console.WriteLine($"В пользовании: {use}");
            }
        }
    }

    public void ChangeBookStatus(string title, bool isAvailable)
    {
        foreach (var item in Books)
        {
            if (item.Title == title)
            {
                if (isAvailable == false)
                {
                    System.Console.WriteLine($"Книга {title} теперь недоступна");
                }
                if (isAvailable == true)
                {
                    System.Console.WriteLine($"Книга {title} доступна");
                }
            }
        }
        
    }
}
