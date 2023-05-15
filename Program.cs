using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodeCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write a 4 digit code: ");
            string code = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Append the typed character to the password string
                if (key.Key != ConsoleKey.Enter)
                {
                    code += key.KeyChar;
                    Console.Write("*"); // Print an asterisk for each character
                    
                }

            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine("\n");
            //string code = Console.ReadKey();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool found = false;
            string checkcode;
           // string[] codeArrayCheck = code.ToCharArray().Select(c => c.ToString()).ToArray();
            //string codecheck = string.Join("", codeArrayCheck);
            int[] codeArrayInt = { 0, 0, 0, 0 };
                for (int l = 0; l < 11; l++)
                {

                    for (int k = 0; k < 11; k++)
                    {

                        for (int j = 0; j < 11; j++)
                        {

                            for (int i = 0; i < 11; i++)
                            {
                                string[] codeArrayString = Array.ConvertAll(codeArrayInt, Convert.ToString);
                                checkcode = string.Join("", codeArrayString);
                                if (checkcode == code)
                                {
                                    found = true;
                                    Console.WriteLine($"code found: {checkcode}");
                                    break;
                                }
                                //Console.WriteLine(checkcode);
                                codeArrayInt[3] = i;

                            }
                            if (found) break;
                            codeArrayInt[2] = j;
                            
                        }
                        if (found) break;
                        codeArrayInt[1] = k;
                    }
                    if (found) break;
                    codeArrayInt[0] = l;
                }

            stopwatch.Stop();
            TimeSpan timeOfExecution = stopwatch.Elapsed;
            double seconds = timeOfExecution.TotalSeconds;
            if(found)Console.WriteLine($"Code found in: {seconds}");
            if (!found) Console.WriteLine("code not found");
            Console.ReadKey();
        }
    }
}
