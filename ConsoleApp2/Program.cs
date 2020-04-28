using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string name=null;
            string password;
            bool autoSave=false;

            Console.WriteLine("do you want to autosave ?(yes/no) ");
            answer = Console.ReadLine().ToLower();
            answer.Trim();
            if (answer == "yes")
            { autoSave = true;
            }
            Console.WriteLine("what is yr name?");
            if (autoSave = true)
            {
                name = Console.ReadLine().Trim();
            }
            else
            {
                Console.ReadLine();
            }
            Console.WriteLine(name);
        }
    }
}
