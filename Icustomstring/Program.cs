using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icustomstring
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedListString CLLS = new CustomLinkedListString();
   
            SystemArrayString SAS = new SystemArrayString();
            Console.WriteLine("Enter a phrase");
            string NewLine = Console.ReadLine();
            SystemString SS = new SystemString(NewLine);
            Console.WriteLine(NewLine.Length);
            Console.ReadKey();

            SystemLinkedListArray SLLA = new SystemLinkedListArray();
            SLLA.Add("Peak");
            SLLA.Add("Level");
            SLLA.Add("Design");
            SLLA.ListNodes();
            Console.WriteLine(SLLA.Retrieve(2).nodecontent);
            Console.ReadKey();
        }
    }
}
