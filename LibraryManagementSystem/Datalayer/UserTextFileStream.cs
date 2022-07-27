using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Datalayer
{
   public class UserTextFileStream
    {
        internal static string studentsBorrowedBooks = "StudentsBorrowedBooks.txt";
        internal static string studentsReturnedBooks = "StudentsReturnedBooks.txt";
        internal static void AppendFile(List<string> userInput, List<string> dateTime)
        {
            Queue<string> deferredLines = new Queue<string>();

            using (StreamWriter file = File.AppendText(studentsBorrowedBooks))
            {

                WriteDataInFile(file, userInput, dateTime);

            }
        }
        internal static void BAppendFile(List<string> userInput, List<string> dateTime)
        {
            Queue<string> deferredLines = new Queue<string>();

            using (StreamWriter file = File.AppendText(studentsReturnedBooks))
            {

                WriteDataInFile(file, userInput, dateTime);

            }
        }

        internal static void WriteDataInFile(StreamWriter file, List<string> userInput, List<string> dateTime)
        {

            foreach (var data in userInput)
            {
                file.Write(data);

                if (data.Length == 2)
                {
                    file.Write("");
                }
                else
                {
                    foreach (var data1 in dateTime)
                    {
                        file.Write($"\t\t{data1}\n");
                    }
                }

            }

        }

        public static List<string> ReturnedReadFile()
        {
            List<string> dataContent = new List<string>();

            using (StreamReader sr = new StreamReader(studentsReturnedBooks))
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
        public static List<string> BorrowedReadFile()
        {
            List<string> dataContent = new List<string>();

            using (StreamReader sr = new StreamReader(studentsBorrowedBooks))
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
        public static string StudentsBorrowedin(string userInput)
        {

            //string userInput 
            switch (userInput)
            {
                case "1":
                    List<string> userName = GetName();
                    List<string> dateTime = Datetime();
                    AppendFile(userName, dateTime);
                    break;

                case "2":
                    break;
                default:
                    break;
            }
            return userInput;
        }
        public static string StudentsReturnedin(string userInput)
        {
            
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    List<string> userName = GetName();
                    List<string> dateTime = Datetime();
                    BAppendFile(userName, dateTime);
                    break;

                case "2":
                    break;
                default:
                    break;
            }
            return userInput;
        }
        internal static List<string> GetName()
        {
            List<string> dataList = new List<string>();
            string userName;
            do
            {

                Console.Write("\n\t\t\t\tStudent ID: ");
                userName = Console.ReadLine();

                if (userName.Length == 15 && userName.StartsWith("20") && userName.EndsWith("BN-0"))
                {
                    dataList.Add(userName);
                    break;
                }
                else
                {
                    Console.WriteLine("\t\t\t\tInvalid Input");

                }
                Console.ReadLine();
                Console.Clear();

            } while (userName.Length != 0);

            return dataList;

        }
        internal static List<string> Datetime()
        {
            List<string> TimeData = new List<string>();
            string date = ($"\t\t\t{DateTime.Now.ToString()}");
            TimeData.Add(date);

            return TimeData;

        }
    }
}
