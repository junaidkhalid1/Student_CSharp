using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2_Student
{
    class Program
    {
        internal int value;

        static void Main(string[] args)
        {
            int input;
            string enter;

            Console.WriteLine("How many students: ");
            input = int.Parse(Console.ReadLine());
            Student[] st = new Student[input];

            for (int i = 0; i < input; i++)
            {

                st[i] = new Student();

                Console.WriteLine("Type name: ");
                enter = Console.ReadLine();
                st[i].name = enter;

                Console.WriteLine("Type score: ");
                enter = Console.ReadLine();
                st[i].score = int.Parse(enter);

            }
            Array.Sort(st);
            for (int i = 0; i < input; i++)
            {
               
                Console.WriteLine(st[i].ToString());

            }      /*
            st[0] = new Student();
            st[1] = new Student();
            st[2] = new Student();

            st[0].score = 12;
            st[0].name = "John Kent";

            st[1].score = 14;
            st[1].name = "Barack Obama";

            st[2].score = 16;
            st[2].name = "Francois Hollande";

            for (int i = 0; i < 3; i++) 
            {
                
                Console.WriteLine(st[i].ToString());

            }

    */
            //string input;
            // Console.WriteLine("Type name: ");
            //  input = Console.ReadLine();
            //st.name = input;
            //Console.WriteLine("Type score: ");
            //input = Console.ReadLine();
            //st.score=float.Parse(input);

            //            Console.WriteLine(st.ToString());
            //Console.WriteLine("Name and score is: "+st.name +" " +st.score);
            //Console.WriteLine("Name and score is:{0} {1} ", st.name, st.score);

            Console.ReadLine();

        }
    }
}
