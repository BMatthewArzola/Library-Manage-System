using System;
using System.Collections.Generic;
using System.IO;
using Datalayer;
namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIBRARY
            Console.WriteLine("\n\t\t\t\t88      88  88888   88888        88      88888   88    88\n\t\t\t\t88      88  88  88  88  88      8888     88  88   88  88\n\t\t\t\t88      88  88888   88888      88  88    88888      88\n\t\t\t\t88      88  88  88  88  88    88888888   88  88     88\n\t\t\t\t888888  88  88888   88   88  88      88  88   88    88");
            Console.WriteLine();
            //MANAGEMENT
            Console.WriteLine("\t88      88      88      88    88      88       888888   888888  88      88  888888 88    88 88888888\n\t8888  8888     8888     8888  88     8888     88        88      8888  8888  88     8888  88    88\n\t88  88  88    88  88    88 88 88    88  88    88  8888  88888   88  88  88  8888   88 88 88    88");
            Console.WriteLine("\t88      88   88888888   88  8888   88888888   88    88  88      88      88  88     88  8888    88\n\t88      88  88      88  88    88  88      88   888888   888888  88      88  888888 88    88    88");
            //SYSTEM
            Console.WriteLine("\n\t\t\t\t 88888 88    88  88888 88888888 888888 88      88\n\t\t\t\t88      88  88  88        88    88     8888  8888\n\t\t\t\t 8888     88     8888     88    8888   88  88  88\n\t\t\t\t    88    88        88    88    88     88      88\n\t\t\t\t88888     88    88888     88    888888 88      88");
            Console.WriteLine("\n\n\n\t\t\t\t\tPress any key to [Start]...");
            Console.ReadLine();
            Console.Clear();
            bool keeplooping = true;
            while (keeplooping)
            {
                string userSelection = DisplayMenu();

                switch (userSelection)
                {
                    case "1":
                        Console.WriteLine("\t\t\t\tLogin to Librarian");
                        Console.Write("\t\t\t\tUsername: ");
                        string facultyUserName = Console.ReadLine();
                        Console.Write("\t\t\t\tPassword: ");
                        string facultyPwd = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine();
                        if (facultyUserName == "admin" && facultyPwd == "admin")
                        {
                            LibrarianDisplayMenu();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        continue;
                    case "2":
                        StudentDisplayMenu();
                        continue;
                    case "3":
                        Console.WriteLine("\t\t\t\t\t|---------------------------|");
                        Console.WriteLine("\t\t\t\t\t|     Thank you for using   |");
                        Console.WriteLine("\t\t\t\t\t| Library Management System |");
                        Console.WriteLine("\t\t\t\t\t|        \\(@^0^@)/          |");
                        Console.WriteLine("\t\t\t\t\t|---------------------------|");
                        //LIBRARY
                        Console.WriteLine("\n\t\t\t\t88      88  88888   88888        88      88888   88    88\n\t\t\t\t88      88  88  88  88  88      8888     88  88   88  88\n\t\t\t\t88      88  88888   88888      88  88    88888      88\n\t\t\t\t88      88  88  88  88  88    88888888   88  88     88\n\t\t\t\t888888  88  88888   88   88  88      88  88   88    88");
                        Console.WriteLine();
                        //MANAGEMENT
                        Console.WriteLine("\t88      88      88      88    88      88       888888   888888  88      88  888888 88    88 88888888\n\t8888  8888     8888     8888  88     8888     88        88      8888  8888  88     8888  88    88\n\t88  88  88    88  88    88 88 88    88  88    88  8888  88888   88  88  88  8888   88 88 88    88");
                        Console.WriteLine("\t88      88   88888888   88  8888   88888888   88    88  88      88      88  88     88  8888    88\n\t88      88  88      88  88    88  88      88   888888   888888  88      88  888888 88    88    88");
                        //SYSTEM
                        Console.WriteLine("\n\t\t\t\t 88888 88    88  88888 88888888 888888 88      88\n\t\t\t\t88      88  88  88        88    88     8888  8888\n\t\t\t\t 8888     88     8888     88    8888   88  88  88\n\t\t\t\t    88    88        88    88    88     88      88\n\t\t\t\t88888     88    88888     88    888888 88      88");

                        keeplooping = false;
                        break;

                    default:
                        break;
                }
            }
        }
        public static string DisplayMenu()
        {
            Console.WriteLine("\n\t\t\t\t|------------------------------------------------|");
            Console.WriteLine("\t\t\t\t|-----|WELCOME TO LIBRARY MANAGEMENT SYSTEM|-----|");
            Console.WriteLine("\t\t\t\t|--------------|                 |---------------|");
            Console.WriteLine("\t\t\t\t|               [1] Librarian                    |");
            Console.WriteLine("\t\t\t\t|               [2] Student                      |");
            Console.WriteLine("\t\t\t\t|               [3] Exit                         |");
            Console.WriteLine("\t\t\t\t|------------------------------------------------|");
            Console.WriteLine();
            Console.Write("\t\t\t\tUser Input: ");
            string userMenuSelection = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();

            return userMenuSelection;
        }

        public static string StudentDisplayMenu()
        {

            while (true)
            {
                Console.WriteLine("\t\t\t\t\t|------------Student-----------|");
                Console.WriteLine("\t\t\t\t\t|------------------------------|");
                Console.WriteLine("\t\t\t\t\t|1 View Books                  |");
                Console.WriteLine("\t\t\t\t\t|2 Search Books                |");
                Console.WriteLine("\t\t\t\t\t|3 Return Books                |");
                Console.WriteLine("\t\t\t\t\t|4 Borrow Books                |");
                Console.WriteLine("\t\t\t\t\t|5 Return to MainMenu          |");
                Console.WriteLine("\t\t\t\t\t|------------------------------|");
                Console.WriteLine();
                Console.Write("\t\t\t\tStudent Input: ");
                string studentSelection = Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                switch (studentSelection)
                {
                    case "1":
                        Console.WriteLine("\t\t\t\tView Books\n");
                        ViewBooks();
                        Console.Clear();
                        continue;
                    case "2":

                        Console.WriteLine("\t\t\t\tSearch Books");
                        BookInformation.SearchBooks();
                        Console.Clear();
                        continue;

                    case "3":

                        Console.WriteLine("\t\t\t\tReturn Books");
                        UserTextFileStream.StudentsReturnedin(random());
                        BookInformation.ReturnBook();
                        Console.WriteLine("\n\t\t\t\tPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();

                        continue;

                    case "4":
                        Console.WriteLine("\t\t\t\tBorrow Books");
                        UserTextFileStream.StudentsBorrowedin(random());
                        BookInformation.BorrowBooks();
                        Console.WriteLine("\n\t\t\t\tPress any key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        continue;

                    case "5":
                        break;

                    default:
                        break;


                }
                return studentSelection;
            }

        }
        public static string LibrarianDisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\t\t\t\t\t|-----------Librarian----------|");
                Console.WriteLine("\t\t\t\t\t|------------------------------|");
                Console.WriteLine("\t\t\t\t\t|1 Add Books                   |");
                Console.WriteLine("\t\t\t\t\t|2 Search Books                |");
                Console.WriteLine("\t\t\t\t\t|3 View Books                  |");
                Console.WriteLine("\t\t\t\t\t|4 Manage Students             |");
                Console.WriteLine("\t\t\t\t\t|5 Return to MainMenu          |");
                Console.WriteLine("\t\t\t\t\t|------------------------------|");
                Console.WriteLine();
                Console.Write("\t\t\t\tLibrarian Input: ");
                string facultySelection = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
                switch (facultySelection)
                {
                    case "1":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\t\tADD BOOKS");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        BookInformation.AddABook();
                        Console.Clear();
                        continue;
                    case "2":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\t\tSEARCH BOOKS");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        BookInformation.SearchBooks();
                        Console.Clear();
                        continue;

                    case "3":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\t\tVIEW BOOKS");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                        ViewBooks();
                        Console.Clear();
                        continue;

                    case "4":
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t\t\t\tMANAGE STUDENTS");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        DisplayStudentData();
                        Console.Clear();
                        continue;

                    case "5":
                        break;

                    default:
                        break;

                }
                return facultySelection;
            }
        }

        private static void DisplayStudentData()
        {
            string choice;

            Console.WriteLine("\n\t\t\t\t|------------------------------------------------|");
            Console.WriteLine("\t\t\t\t|          1 Student who Returned Books          |");
            Console.WriteLine("\t\t\t\t|          2 Student who Borrowed Books          |");
            Console.WriteLine("\t\t\t\t|------------------------------------------------|");
            Console.Write("\n\t\t\t\tUserInput: ");
            choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    List<string> dataContent = UserTextFileStream.ReturnedReadFile();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t\t\t\tStudent Who Returned Books");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");
                    Console.WriteLine("\t\t\t\tStudent Name\t\t\t\t\tDate Time");
                    foreach (var data in dataContent)
                    {
                        Console.WriteLine($"\n\t\t\t\t{data}\n");
                    }
                    break;
                case "2":
                    List<string> dataContent1 = UserTextFileStream.BorrowedReadFile();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\t\t\t\t\t\tStudent Who Borrowed Books");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");
                    Console.WriteLine("\t\t\t\tStudent Name\t\t\t\t\tDate Time");
                    foreach (var data in dataContent1)
                    {
                        Console.WriteLine($"\n\t\t\t\t{data}\n");
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n\n\t\t\t\t\tPress any key to back from Menu...");
            Console.ReadLine();
        }

        public static void ViewBooks()
        {
            List<string> dataContent = BookInformation.ReadFile();
            Console.WriteLine("\t\t\t\tBook Name\tBook Author\tBook ID\n");

            foreach (var data in dataContent)
            {
                Console.WriteLine("\t\t\t\t---------------------------------------");
                Console.WriteLine($"\t\t\t\t{data}\n");
                Console.WriteLine("\t\t\t\t---------------------------------------");
            }

            Console.WriteLine("\n\t\t\t\tPress any key to back from Menu...");
            Console.ReadKey();
        }
        public static string random()

        {
            Console.WriteLine("\n\t\t\t\t|-----------------------------|");
            Console.WriteLine("\t\t\t\t|          1 Sign-in          |");
            Console.WriteLine("\t\t\t\t|          2 Back             |");
            Console.WriteLine("\t\t\t\t|-----------------------------|");
            Console.Write("\n\t\t\t\tUserInput: ");
            string userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
        }

    }
}