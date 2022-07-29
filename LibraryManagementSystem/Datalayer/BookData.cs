using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public class BookData
    {
        public static string fileName = "Books.txt";
        public static void AppendFile(List<string> bookName, List<string> authorName, List<string> idBook)
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

        public static List<string> ReadFile()
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
    }
}
