namespace CSProjeDemo1
{
    public class Library
    {
        public List<Member> Members { get; private set; } = new List<Member>();
        public List<Book> Books { get; private set; } = new List<Book>();

        public void LendBookToMember(Member member, Book book)
        {
            if (book.Status != BookStatus.Borrowable || !Books.Contains(book)) return;
            bool lendedSuccessfully = member.BorrowBook(book);
            if (lendedSuccessfully) book.LendedBookCount++;
        }
        public void GetBookBackFromMember(Member member, Book book)
        {
            if (book.LendedBookCount <= 0) return;
            bool gotBackSuccessfully = member.ReturnBook(book);
            if (gotBackSuccessfully) book.LendedBookCount--;
        }
    }
}
