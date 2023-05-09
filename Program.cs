using System;
using System.IO;

namespace act5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            try
            {
                StreamReader sr = new StreamReader("D:\\movie\\CODE\\StreamReader.txt");

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();

                StreamWriter sw = new StreamWriter("D:\\movie\\CODE\\StreamReader.txt");

                sw.WriteLine("Hello Activity_5!!");
                sw.WriteLine("From Activity_5");

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}