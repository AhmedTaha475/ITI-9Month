using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8_SD43_Task
{
    internal class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }

        public string[] Authors { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }

        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ISBN);
            sb.Append("\n");
            sb.Append(Title);
            sb.Append('\n');
            sb.Append(PublicationDate.ToString());
            sb.Append("\n");
            sb.Append("Authors: ");
            sb.Append(" ");
            for (int i = 0; i < Authors.Length; i++)
            {
                sb.Append($"{i+1}){Authors[i]}");
                sb.Append("\n");
            }
            sb.Append(Price);
            return sb.ToString();
        }
    }



    internal class BookFunctions 
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            StringBuilder sb= new StringBuilder();
            for (int i = 0; i < B.Authors.Length; i++)
            {
                sb.Append($"{i + 1}){B.Authors[i]}");
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();        
        }

    }
}
