using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS2_Student
{
    class Threads
    {
        public String input = "go";
        public void func_thread()
        {
            while (input != "quit")
            {
                Console.WriteLine("Hello");
                Thread.Sleep(1000);
            }

        }

    }
}
