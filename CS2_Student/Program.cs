using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2_Student
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Comparer cp = new Comparer();
            TestDelegate td = new TestDelegate();

            //cp.display();
            //cp.tests();
            td.delegates();

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
