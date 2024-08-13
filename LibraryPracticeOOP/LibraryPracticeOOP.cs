using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPracticeOOP
{
    public class Library
    {
        public string _bookName;
        public string _authorName;
        public string _authorSurname;
        public int _pageCount;
        public string _publisher;

        public DateTime _regDate;

        public string Bookname
        {

            get { return _bookName; }


            set { _bookName = value; }
        }

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }
        public string AuthorSurname
        {
            get { return _authorSurname; }
            set { _authorSurname = value; }
        }

        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }


        public Library(string bookName, string authorName, string authorSurname, int pageCount, string publisher)
        {
            _bookName = bookName;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _pageCount = pageCount;
            _publisher = publisher;


        }

        public Library()
        {


        }


        public void Date()
        {
            _regDate = DateTime.Now;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Book Name {_bookName}\n Author Name {_authorName}\n Author Surname {_authorSurname}\n Page Count {_pageCount}\n Publisher {_publisher} ");
        }


    }
}