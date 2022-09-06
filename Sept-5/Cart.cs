using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sept5_handson
{
    public  class Cart:Book
    {
		private int _bookid;

		public new int BookID
		{
			get { return _bookid; }
			set { _bookid = value; }
		}

		private int _price;

		public new int Price
		{
			get { return _price; }
			set { _price = value; }
		}



		private int _custid;

		public int CustID
		{
			get { return _custid; }
			set { _custid = value; }
		}



		public void AddtoCart(int custid,int bookid,int price)
		{
			this.CustID=custid;
			this.BookID=bookid;
			this.Price = price;

		}


		public static List<Book> BookList = new List<Book>(); // Creating A BookList

		int _bid;
		string _bname;
		int _p;

		
		public void DisplayBook(int custid,string bookname,int price)
		{
			_bid=base.BookID;
			_bname = base.BookName;
			_p=base.Price;



		}
        public void AcceptData()
        {
            Book p = new Book();

            Console.WriteLine("Enter Book ID: ");
            p.BookID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Name: ");
            p.BookName = Console.ReadLine();

            Console.WriteLine("Enter Book Price: ");
            p.Price = Convert.ToInt32(Console.ReadLine());

            InsertBook(p);
            Console.WriteLine("Book added successfully...");
        }
        public void InsertBook(Book BookData)
        {
            BookList.Add(BookData);
        }
        public List<Book> BooksList()
        {
            return BookList;
        }

        static int Count;
        public void BookCount()
        {
            Count = Count + 1;
            Console.WriteLine("The no. of books added are : " + Count);

        }




    }
}
