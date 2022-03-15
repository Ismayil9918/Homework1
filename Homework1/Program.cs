using System;
using System.Collections;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add("1999", "Java");
            sortedList.Add("1998", "C#");
            sortedList.Add("2005", "GO");
            sortedList.Add("2000", "Pyton");

            

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key+" "+item.Value);
                
                
            }


            SortedList sortedList1 = new SortedList();
            sortedList1.Add("Java", "1999");
            sortedList1.Add("C#", "1998");
            sortedList1.Add("GO", "2005");
            sortedList1.Add("Pyton", "2000");

            foreach (DictionaryEntry item in sortedList1)
            {
                Console.WriteLine(item.Key+" "+item.Value);

            }
        }
    }
}
