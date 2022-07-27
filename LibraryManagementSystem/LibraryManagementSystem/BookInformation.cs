using System;
using System.Collections.Generic;
using System.IO;

namespace Datalayer
{
    class BookInformation
    {
        internal static string fileName = "Books.txt";
        internal static void AppendFile(List<string> bookName, List<string> authorName, List<string> idBook)
        {
            Queue<string> deferredLines = new Queue<string>();

            using (StreamWriter file = File.AppendText(fileName))
            {

                WriteDataInFile(file, bookName, authorName, idBook);

            }
        }

        internal static void WriteDataInFile(StreamWriter file, List<string> bookName, List<string> authorName, List<string> bookid)
        {


            foreach (var data in bookName)
            {

                file.Write(data);

                if (data.Length == 1 || data.Length == 2)
                {
                    file.Write("");
                }
                else
                {
                    foreach (var data1 in authorName)
                    {

                        file.Write($"\t{data1}");
                    }

                    foreach (var data2 in bookid)
                    {

                        file.Write($"\t{data2}\n");
                    }
                }

            }

        }

        internal static List<string> ReadFile()
        {
            List<string> dataContent = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {

                string line = sr.ReadLine();

                while (line != null)
                {

                    dataContent.Add(line);

                    line = sr.ReadLine();
                }
            }

            return dataContent;
        }

        internal static void SearchBooks()
        {
            Console.WriteLine("\t\t\t\t---------------------------------------");
            Console.Write("\t\t\t\tName of Book: ");
            string searchBookName = Console.ReadLine().ToUpper();
            Console.WriteLine("\t\t\t\t---------------------------------------");
            var lines = File.ReadAllLines(fileName);

            string result = null;
            foreach (var line in lines)
            {
                if (line.Contains(searchBookName))
                {
                    result = line;
                    break;
                }
            }
            Console.WriteLine("\n\t\t\t\t---------------------------------------");
            Console.WriteLine("\t\t\t\tBook Name\tBook Author\tBook ID\n");
            Console.WriteLine($"\t\t\t\t{result}" ?? "No results");
            Console.WriteLine("\t\t\t\t---------------------------------------");


            Console.ReadLine();

        }
        internal static void BorrowBooks()
        {
            string userinput;

            do
            {
                Console.Write("\n\t\t\tBook Name: ");
                string borrowBookName = Console.ReadLine().ToUpper();
                var lines = File.ReadAllLines(fileName);

                string result = null;
                foreach (var line in lines)
                {
                    if (line.Contains(borrowBookName))
                    {
                        result = line;

                    }
                }
                if (borrowBookName != string.Empty)
                {
                    Console.WriteLine("\n\t\t\tIs this the book you will borrow? ");
                    Console.WriteLine("\t\t\t---------------------------------------");
                    Console.WriteLine("\t\t\tBook Name\tBook Author\tBook ID");
                    Console.WriteLine("\t\t\t---------------------------------------");
                    Console.WriteLine($"\t\t\t{result}");
                    Console.WriteLine("\t\t\t---------------------------------------");
                    Console.Write("\n\t\t\t(y/n): ");
                    userinput = Console.ReadLine().ToLower();

                    if (userinput == "y")
                    {
                        Console.WriteLine("\n\t\t\t---------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\tBook Name\tBook Author\tBook ID");
                        Console.WriteLine($"\t\t\tBook Borrowed: {result} \n\t\t\tDate Borrowed: {DateTime.Now.ToString()}");
                        Console.WriteLine("\t\t\t---------------------------------------------------------");
                        break;
                    }
                    else if (userinput == "n")
                    {
                        continue;
                    }
                }
                else
                {
                    break;
                }
            } while (true);

        }
        internal static void ReturnBook()
        {
            string userinput;

            do
            {
                Console.Write("\n\t\t\tBook ID: ");
                string borrowBookName = Console.ReadLine().ToUpper();
                var lines = File.ReadAllLines(fileName);

                string result = null;
                foreach (var line in lines)
                {
                    if (line.Contains(borrowBookName))
                    {
                        result = line;
                    }
                }
                if (borrowBookName != string.Empty)
                {
                    Console.WriteLine("\n\t\t\tIs this the book you return? ");
                    Console.WriteLine("\t\t\t---------------------------------------");
                    Console.WriteLine("\t\t\tBook Name\tBook Author\tBook ID");
                    Console.WriteLine("\t\t\t---------------------------------------");
                    Console.WriteLine($"\t\t\t{result}");
                    Console.WriteLine("\t\t\t---------------------------------------");
                    Console.Write("\n\t\t\t(y/n): ");
                    userinput = Console.ReadLine().ToLower();

                    if (userinput == "y")
                    {
                        Console.WriteLine("\n\t\t\t---------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\tBook Name\tBook Author\tBook ID");
                        Console.WriteLine($"\t\t\tBook Returned: {result} \n\t\t\tDate Returned: {DateTime.Now.ToString()}");
                        Console.WriteLine("\t\t\t---------------------------------------------------------");
                        break;
                    }
                    else if (userinput == "n")
                    {
                        continue;
                    }
                }
                else
                {
                    break;
                }
            } while (true);

        }
        public static void AddABook()
        {
            List<string> bookName = new List<string>();
            List<string> bookAuthor = new List<string>();
            List<string> bookId = new List<string>();
            string bookname = string.Empty, bookauthor = string.Empty, bookid = string.Empty;
            Console.Write("\n\t\t\t\tBook Name: ");
            bookname = Console.ReadLine().ToUpper();
            bookName.Add(bookname);

            Console.Write("\t\t\t\tBook Author: ");
            bookauthor = Console.ReadLine().ToUpper();
            bookAuthor.Add(bookauthor);

            Console.Write("\t\t\t\tBook ID: ");
            bookid = Console.ReadLine().ToUpper();
            bookId.Add(bookid);
            BookInformation.AppendFile(bookName, bookAuthor, bookId);

            Console.WriteLine("\n\t\t\tBook Name\t\tBook Author\t\tBook ID");

            foreach (var data in bookName)
            {
                Console.Write($"\n\t\t\t{data}");

            }
            foreach (var data1 in bookAuthor)
            {
                Console.Write($"\t\t{data1}");

            }

            foreach (var data2 in bookId)
            {
                Console.Write($"\t\t{data2}\n");

            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
    }
}