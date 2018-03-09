using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_part_1_creating_simple_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action delegate
            Task task1 = new Task(new Action(HelloConsole));

            //anonymous function
            Task task2 = new Task(delegate
            {
                HelloConsole();
            });
            
            //lambda expression
            Task task3 = new Task(() => HelloConsole());
            Task task4 = new Task(() => HelloConsole());
            Task task5 = new Task(() => HelloConsole());
            Task task6 = new Task(() => HelloConsole());

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
            task6.Start();

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
        static void HelloConsole()
        {
            Console.WriteLine("Hello Task");
        }
    }
}
