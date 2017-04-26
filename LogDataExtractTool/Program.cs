using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDataExtractTool
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var filePath = "";
                var selectString = "";
                if (args.Length > 1)
                {
                    filePath = args[0];
                    selectString = args[1];
                }
                else
                {
                    Console.WriteLine("Input File path and name.");
                    filePath = Console.ReadLine();
                    Console.WriteLine("Input string what you want to select.");
                    selectString = Console.ReadLine();
                }

                filePath = filePath.Replace("\"",""); 

                Console.WriteLine("Input File Path + Name : " + filePath);

                LogDataExtract.ExtractData(filePath, selectString);
             }
        }
    }
}
