using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applayer
{
    public class DataValidate
    {
        public static List<string> GetName()
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
        public static List<string> Datetime()
        {
            List<string> TimeData = new List<string>();
            string date = ($"\t\t\t{DateTime.Now.ToString()}");
            TimeData.Add(date);

            return TimeData;

        }
    }
}
