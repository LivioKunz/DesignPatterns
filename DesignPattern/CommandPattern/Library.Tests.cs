using FluentAssertions;
using Xunit;

namespace CommandPattern
{
    public class LibarayTests
    {
        [Fact]
        public void Test_Command_Pattern()
        {
            Libraray libarayManager = new Libraray();
            Book book1 = new Book("bla bla");

            Borrow borrowBook = new Borrow(book1);

            libarayManager.HandleBook(borrowBook);
            borrowBook.IsProcessed.Should().BeFalse();

            libarayManager.ProcessAll();
            borrowBook.IsProcessed.Should().BeTrue();

            Return returnBook = new Return(book1);
            libarayManager.HandleBook(returnBook);

            returnBook.IsProcessed.Should().BeFalse();

            libarayManager.ProcessAll();
            returnBook.IsProcessed.Should().BeTrue();
        }
    }
}