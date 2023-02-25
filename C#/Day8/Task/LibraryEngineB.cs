using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8_SD43_Task
{
    internal class LibraryEngineB
    {

        public static void ProcessBooks(List<Book> blist, Func<Book,string> dt)
        {
            foreach (Book book in blist)
            {
                Console.WriteLine(dt.Invoke(book));
            }
        }
    }
}
