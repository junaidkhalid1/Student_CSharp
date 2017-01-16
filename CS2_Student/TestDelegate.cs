using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

delegate int pow(int n);
namespace CS2_Student
{
    class TestDelegate
    {
        public void delegates()
        {
            Calculus cal = new Calculus();
            pow ptwo = new pow(cal.powtwo);
            pow pthree = new pow(cal.powthree);
            pow pfour = new pow(cal.powfour);

            int powtwo = ptwo.Invoke(2);
            int powthree = pthree.Invoke(4);
            int powfour = pfour.Invoke(6);

            Console.WriteLine(powtwo);
            Console.WriteLine(powthree);
            Console.WriteLine(powfour);

        }
    }
}