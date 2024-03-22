
namespace CSProjeDemo1
{
    public class Member : IMember
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MemberNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public bool BorrowBook(Book book)
        {
            if (BorrowedBooks.Contains(book)) return false;
            BorrowedBooks.Add(book);
            return true;
        }

        public bool ReturnBook(Book book)
        {
            if (!BorrowedBooks.Contains(book)) return false;
            BorrowedBooks.Remove(book);
            return true;
        }
    }
}
