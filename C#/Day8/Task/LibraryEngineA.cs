using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8_SD43_Task
{
    internal delegate string bookDelDt(Book B);
    internal class LibraryEngineA
    {

        public static void ProcessBooks (List<Book> blist,bookDelDt dt)
        {
            foreach (Book book in blist)
            {
                Console.WriteLine(dt.Invoke(book));
            }
        }

    }
}
