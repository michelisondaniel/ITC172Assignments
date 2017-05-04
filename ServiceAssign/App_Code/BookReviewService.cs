using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookReviewService" in code, svc and config file together.
public class BookReviewService : IBookReviewService

{
    BookReviewDbEntities db = new BookReviewDbEntities();
    public List<BookInfo> GetBooks() // Gets all da books
    {
        var bks = from b in db.Books
                  select b;

        List<BookInfo> books = new List<BookInfo>(); // Querying all books and then adding them to our new class
        foreach(Book bk in bks)
        {
            BookInfo booko = new BookInfo();
            booko.BookTitle = bk.BookTitle;
            booko.BookEntryDate = bk.BookEntryDate.ToShortDateString();
            booko.BookISBN = bk.BookISBN;
            booko.BookAuthor = new List<Author>();
            foreach(Author a in bk.Authors)
            {
                Author au = new Author();
                au.AuthorName = a.AuthorName;
                booko.BookAuthor.Add(au);
            }
            books.Add(booko);
        }
        return books;
    }

    public BookInfo GetBooksByAuthor(string authorName)
    {
        throw new NotImplementedException();
    }

    public int Login(string user, string password)
    {
        throw new NotImplementedException();
    }

    public bool RegisterReviewer(Reviewer r)
    {
        throw new NotImplementedException();
    }
}
