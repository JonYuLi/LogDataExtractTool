using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDataExtractTool
{
    class LogDataExtract
    {
        public string ssss { get; set; }
        public static void ExtractData(string filePathName, string selectString)
        {
            if (!File.Exists(filePathName))
            {
                Console.WriteLine("{0} does not exist.", filePathName);
                return;
            }

            StreamReader sr = File.OpenText(filePathName);
            StreamWriter sw = File.CreateText(filePathName + "ex");

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if(line.Contains(selectString))
                    sw.WriteLine(line);
            }
            Console.WriteLine("The end of the stream has been reached.");
            sr.Close();
            sw.Close();
        }
    }
}
