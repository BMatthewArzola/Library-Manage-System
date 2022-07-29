using System;
using System.Collections.Generic;
using System.IO;
using Applayer;
namespace Datalayer
{
   public class ReturnedBookData
    {
       
        public static string studentsReturnedBooks = "StudentsReturnedBooks.txt";
        
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
       
       
        public static string StudentsReturnedin(string userInput)
        {
            
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    List<string> userName = DataValidate.GetName();
                    List<string> dateTime = DataValidate.Datetime();
                    BAppendFile(userName, dateTime);
                    break;

                case "2":
                    break;
                default:
                    break;
            }
            return userInput;
        }
       
    }
}
