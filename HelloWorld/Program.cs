using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String exit = "";
            do
            {
                Message message = new Message(9, 13, 18);
                System.Console.WriteLine(message.GetHelloMessage() + " " + Environment.UserName);
                exit = System.Console.ReadLine();
            } while (exit != "exit");
        }
    }
}
