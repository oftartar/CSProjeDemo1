namespace CSProjeDemo1
{
    abstract public class Book
    {
        public Guid Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int TotalBookCount { get; set; }
        public int LendedBookCount { get; set; }
        public BookStatus Status
        {
            get
            {
                if (TotalBookCount == 0) return BookStatus.NotAvailable;
                else
                {
                    if (LendedBookCount < TotalBookCount) return BookStatus.Borrowable;
                    else return BookStatus.Unborrowable;
                }
            }
        }
    }
}
