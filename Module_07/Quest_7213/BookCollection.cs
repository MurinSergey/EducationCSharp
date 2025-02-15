using System;

namespace Module_07.Quest_7213;

public class BookCollection
{
    private Book[] books;

    public BookCollection(Book[] books){
        this.books = books;
    }

    //Индексатор по номеру в массиве
    public Book this [int index] {
        get {
            if (index >= 0 && index < books.Length){
                return books[index];
            } else {
                return null;
            }
        }
        set {
            if (index >= 0 && index < books.Length){
                books [index] = value;
            }
        }
    }

    //Индексатор по имени без сеттора
    public Book this [string name] {
        get {
            for (int i = 0; i < books.Length; i++){
                if (books[i].Name == name){
                    return books[i];
                }
            }
            return null;
        }
    }
}
