using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Book
    {


		public Book() //default Constructor
		{
			BookName = "c#";

		}


		public Book(int bookid) //p-Constr
		{
			_bookid = bookid;
			
			
		}	

		private int _bookid;

		public int BookID
		{
			get { return _bookid; }
			set { _bookid = value; }
		}

		private string _bookname;

		public string BookName
		{
			get { return _bookname; }
			set { _bookname = value; }
		}

		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}

		private string _author;

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		public void InsertBook(int bookid,string bookname,int price)
		{
			this.BookID = bookid;
			this.BookName= bookname;
			this.Price= price;
		}

		public void InsertBook(int bookid, int price,string bookname, string author)
		{
            this.BookID = bookid;
            this.BookName = bookname;
            this.Price = price;
			this.Author =author;
        }

		public void InsertBook(int bookid , string bookname)
		{
			this.BookID = bookid;
			this.BookName = bookname;

		}

		public class Novel : Book
		{
			private int _nopages;

			public int NoofPages
			{
				get { return _nopages; }
				set { _nopages = value; }
			}




			public void InsertBook(int bookid,string bookname,int price,int noofpages)
			{
				this.BookID= bookid;
				this.BookName = bookname;
				this.Price = price;
				this.NoofPages=noofpages;

			}




		}





	}
}
