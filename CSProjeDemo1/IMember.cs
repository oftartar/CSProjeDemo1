namespace CSProjeDemo1
{
    public interface IMember
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MemberNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        bool BorrowBook(Book book);
        bool ReturnBook(Book book);
    }
}
