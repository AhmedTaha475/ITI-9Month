namespace D8_SD43_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("1234", "ali botter1", new string[] { "ahmed1", "mohamed1", "baher1", "mohsn1" }, DateTime.Now, 250.6M);
            Book b2 = new Book("1235", "ali botter2", new string[] { "ahmed2", "mohamed2", "baher2", "mohsn2" }, DateTime.Now, 260.6M);
            Book b3 = new Book("1236", "ali botter3", new string[] { "ahmed3", "mohamed3", "baher3", "mohsn3" }, DateTime.Now, 270.6M);
            Book b4 = new Book("1237", "ali botter4", new string[] { "ahmed4", "mohamed4", "baher4", "mohsn4" }, DateTime.Now, 280.6M);
            Book b5 = new Book("1238", "ali botter5", new string[] { "ahmed5", "mohamed5", "baher5", "mohsn5" }, DateTime.Now, 290.6M);


            List<Book> lst = new List<Book>();
            lst.Add(b1);
            lst.Add(b2);
            lst.Add(b3);
            lst.Add(b4);
            lst.Add(b5);

            #region Taska

            //LibraryEngineA.ProcessBooks(lst, BookFunctions.GetTitle);
            //Console.WriteLine("======================================");
            //LibraryEngineA.ProcessBooks(lst, BookFunctions.GetAuthors);
            //Console.WriteLine("======================================");
            //LibraryEngineA.ProcessBooks(lst, BookFunctions.GetPrice);
            #endregion

            #region Taskb
            LibraryEngineB.ProcessBooks(lst, BookFunctions.GetTitle);
            Console.WriteLine("======================================");
            LibraryEngineB.ProcessBooks(lst, BookFunctions.GetAuthors);
            Console.WriteLine("======================================");
            LibraryEngineB.ProcessBooks(lst, BookFunctions.GetPrice);
            LibraryEngineB.ProcessBooks(lst, delegate (Book b) { return b.ISBN; });
            LibraryEngineB.ProcessBooks(lst, b => b.PublicationDate.ToString());
            #endregion
        }
    }
}