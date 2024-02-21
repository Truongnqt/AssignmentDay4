using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
	 class Book
	{
		private string _isbn;
		private string _bookName;
		private string _authorName;
		private string _publisherName;

		// Constructor
		public Book() { }
		public Book(string isbn, string bookName, string authorName, string publisherName)
		{
			this._isbn = isbn;
			this._bookName = bookName;
			this._authorName = authorName;
			this._publisherName = publisherName;
			
		}
		public void SetIsbn(string isbn)
		{
			try
			{
				long parsedIsbn = Convert.ToInt64(isbn);
				this._isbn = isbn;
			}
			catch (FormatException)
			{
				Console.WriteLine("Invalid input for ISBN. Please enter a valid number.");
			}
			
			this._isbn = isbn; 
		}
		public string GetIsbn() { return this._isbn; }
		public void SetBookName(string bookName){ this._bookName = bookName; 		}	
		public string GetBookName() { return this._bookName; }
		public void SetAuthorName(string authorName) { this._authorName = authorName; }
		public string GetAuthorName() { return this._authorName; }
		public void SetPublisherName(string publisherName) { this._publisherName = publisherName; }
		public string GetPublisherName() { return this._publisherName; }
		
		public string GetBookInformation()
		{
			return $"{_isbn} {_bookName} {_authorName} {_publisherName}";
		}
	}
}
