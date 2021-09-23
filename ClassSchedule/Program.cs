/*
 Name: Caleb Keller
 Date: 9/10/2021
 Class Period: 9-10
 Project: Class Schedule
 */
//imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace
namespace ClassSchedule
{
    class Program
    {
        static void Main(string[] args)//this is where everything happens
        {
            //a decent schedule is displayed in a table looking format.
            Console.WriteLine("\n\n\n");
            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|---------1st---------|---------2nd---------|---------3rd---------|---------4th---------|---------5th---------|\n" +
                              "|  Financial Literacy |  Political Science  |     AP Calculus     |       ASL II        |      Semminary      |\n" +
                              "|---------6th---------|---------7th---------|---------8th---------|---------9th---------|---------10th--------|\n" +
                              "|    AP Literature    |      Woods II       |     AP Calculus     |            C# Programming CLC             |");
            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------|");
            Console.ReadLine();
            //end

        }
    }
}
