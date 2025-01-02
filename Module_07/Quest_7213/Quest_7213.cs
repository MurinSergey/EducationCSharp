using System;

namespace Module_07.Quest_7213;

public class Quest_7213
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("===Запускается задание 7.2.13===");

        Book[] books= new Book[]{
            new Book { Name = "Book1", Author = "Author1"},
            new Book { Name = "Book2", Author = "Author2"}
        };

        BookCollection bookCollection= new BookCollection(books);

        Book book = bookCollection[1];
        Console.WriteLine($"{book.Name} {book.Author}");

        book = bookCollection[-1];
        
        book = bookCollection[2];

        book = bookCollection["Book1"];
        Console.WriteLine($"{book.Name} {book.Author}");
    }
}
