using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS2_Student
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Comparer cp = new Comparer();
            TestDelegate td = new TestDelegate();
            Threads thread = new Threads();

            //cp.display();
            //cp.tests();
            //td.delegates();
            Thread Myth = new Thread(new ThreadStart(thread.func_thread));
            Myth.Start();
            
            while(thread.input != "quit")
            {
                thread.input = Console.ReadLine();
            }
             
            //thread.func_thread();

            Console.ReadLine();

        }



    }



    //TO make non static
    /*
    maincalls myprog
        myprog = new maincalls
        myprog.start();
        */
}
