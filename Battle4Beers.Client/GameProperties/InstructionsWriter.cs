using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle4Beers.Client.GameProperties
{
    public class InstructionsWriter
    {
        public static void WriteInstructions()
        {
            var lines = File.ReadAllLines("../../Instructions.txt");
            var entry = new ConsoleKeyInfo();
            while (entry.Key != ConsoleKey.Enter)
            {   
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                entry = Console.ReadKey();
            }
        }
    }
}
