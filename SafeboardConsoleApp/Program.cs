using System;
using SafeboardKernel.ScanFacade;
using System.Linq;
using System.Collections.Generic;

namespace SafeboardConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScanFacade scanFacade = new ScanFacade();

            Console.WriteLine("To scan directory enter: scan_util 'path' ");
            Console.WriteLine("To exit enter: 0 ");

            while (true)
            {
                var data = Console.ReadLine().Split(" ");
                string action = data[0]; ;
                string directoryPath = "";

                if (data.Length > 1)
                    directoryPath = data[1];

                if (action == "scan_util")
                {
                    if (string.IsNullOrWhiteSpace(directoryPath))
                    {
                        Console.WriteLine("Enter path to directory");
                    }                        
                    else
                    {
                        var response = scanFacade.Scan(directoryPath);

                        Array.ForEach(response, r => Console.WriteLine(r));
                    }
                }
                else if (action == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect action");
                }
            }
        }
    }
}
