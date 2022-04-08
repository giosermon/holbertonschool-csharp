using System;
using System.Linq;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static void Main()
        {
            JSONStorage storage = new JSONStorage();
            Commands command = new Commands();
            string input;
            string[] inputSplit;
            List<string> commands = new List<string>() { "ClassNames", "All", "Create", "Show", "Update", "Delete", "Exit" };

            storage.Load();
            Prompt.Print();
            for (;;)
            {
                input = "";
                input = Console.ReadLine();
                inputSplit = input.Split();

                if (inputSplit[0].Equals("ClassNames", StringComparison.OrdinalIgnoreCase)) {
                    command.ClassNames(storage);
                } else if (inputSplit[0].Equals("All", StringComparison.OrdinalIgnoreCase)) {
                    if (inputSplit.Count() > 1) {
                        command.All(storage, inputSplit[1]);
                    } else {
                        command.All(storage);
                    }
                    if (inputSplit.Count() > 2)
                        Console.WriteLine("Any argument after the first two was ignored.");
                } else if (inputSplit[0].Equals("Create", StringComparison.OrdinalIgnoreCase)) {
                    if (inputSplit.Count() > 1) {
                        command.Create(storage, inputSplit[1]);
                    } else {
                        Console.WriteLine("Please input a ClassName.");
                    }
                } else if (inputSplit[0].Equals("Show", StringComparison.OrdinalIgnoreCase)) {
                    
                } else if (inputSplit[0].Equals("Update", StringComparison.OrdinalIgnoreCase)) {
                    
                } else if (inputSplit[0].Equals("Delete", StringComparison.OrdinalIgnoreCase)) {
                    
                } else if (inputSplit[0].Equals("Exit", StringComparison.OrdinalIgnoreCase)) {
                    command.Exit(storage);
                } else {
                    Console.WriteLine("\r\nPlease input a valid command.\r\n");
                    continue;
                }

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\r\n_________________________");

                Prompt.Print();
            }
        }
    }
}
