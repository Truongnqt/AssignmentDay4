using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentDay5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LinkedList<Book> books = new LinkedList<Book>();
			Menu(books);
		}
		public static bool CheckNumber(string number)
		{
			string regexPattern = @"[0-9]{9}";


			if (Regex.IsMatch(number, regexPattern))
			{
				return true; 
			}
			else
			{
				return false;
			}
		}
		public static void  AddBook(LinkedList<Book> books)
		{ 

            Console.WriteLine("ISBN: ");
			string isbn = Console.ReadLine();
			while(!CheckNumber(isbn))
			{
				Console.WriteLine("Invalid input for ISBN. Please enter a valid number(9 character). Input again: ");
				isbn = Console.ReadLine();
				
			}
			Console.Write("Book Name: ");
			string bookName=Console.ReadLine();
			Console.Write("Author Book: ");
			string authorName = Console.ReadLine();
			Console.Write("Publisher Name: ");
			String publisherName=Console.ReadLine();
			try
			{
				Book book = new Book(isbn, bookName, authorName, publisherName);
				books.AddLast(book);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
		public static void DisplayallBooks(LinkedList<Book> books)
		{
            Console.WriteLine("Detail list books");
            foreach(var item in books)
			{
				Console.WriteLine(item.GetBookInformation());
			}
        }
		public static void Menu(LinkedList<Book> books)
		{
			while(true)
			{
				Console.WriteLine("Menu");
				Console.WriteLine("1. Add book");
				Console.WriteLine("2. Display books");
				Console.WriteLine("3  Exit");
				string choice;
                Console.Write("Choice : ");
                choice = Console.ReadLine();
				try
				{
					if (int.TryParse(choice, out int nchoice))
					{
						switch (nchoice)
						{
							case 1:
								AddBook(books);
								break;
							case 2:
								DisplayallBooks(books);
								break;
							case 3:
								Environment.Exit(0);
								break;
							default: 
								Console.WriteLine("No option");
								break;
						}
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter a number.");
					}
				}

				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
			}
		}
	}
}
