using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Libraray
    {
        private readonly List<IBorrowBook> borrowList = new List<IBorrowBook>();

        public bool BooksAreLent
        {
            get { return this.borrowList.Any(x => x.IsProcessed); }
        }

        public void HandleBook(IBorrowBook book)
        {
            this.borrowList.Add(book);
        }

        public void ProcessAll()
        {
            foreach (IBorrowBook borrowBook in this.borrowList)
            {
                if (!borrowBook.IsProcessed)
                {
                    borrowBook.Process();
                }
            }
        }

        public static void Main(string[] args)
        {
            var customerBook1 = new Book("bla bla");
            
        }
    }

    public class Book
    {
        public Book(string name)
        {
            Name = name;
        }

        private string Name { get; set; }

    }

    public interface IBorrowBook
    {
        bool IsProcessed { get; set; }
        List<Book> BorrowedBooks { get; set; }
        void Process();
    }

    public class Borrow : IBorrowBook
    {
        private readonly Book book;
        

        public Borrow(Book book)
        {
            this.book = book;
            this.BorrowedBooks = new List<Book>();
        }
        
        public bool IsProcessed { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public void Process()
        {
            BorrowedBooks.Add(this.book);
            this.IsProcessed = true;
        }
    }

    public class Return : IBorrowBook
    {
        private readonly Book book;

        public Return(Book book)
        {
            this.book = book;
            this.BorrowedBooks = new List<Book>();
        }

        public bool IsProcessed { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public void Process()
        {
            this.BorrowedBooks.Remove(this.book);
            this.IsProcessed = true;
        }
    }
}
