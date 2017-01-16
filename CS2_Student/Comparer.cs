using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2_Student
{
    public class Comparer
    {

        public void display()
        {
            int intstudent;
            string enter;

            Console.WriteLine("How many students: ");
            intstudent = int.Parse(Console.ReadLine());
            //Student[] st = new Student[intstudent];

            List<Student> st = new List<Student>();

            for (int i = 0; i < intstudent; i++)
            {

                //st[i] = new Student();
                st.Add(new Student());

                Console.WriteLine("Type name: ");
                enter = Console.ReadLine();
                st[i].name = enter;

                Console.WriteLine("Type score: ");
                enter = Console.ReadLine();
                st[i].score = int.Parse(enter);

            }
            st.Sort();
            //Array.Sort(st);
            for (int i = 0; i < intstudent; i++)
            {
               
                Console.WriteLine(st[i].ToString());

            }
            
            Student comp = new Student();
            //st.Sort(st, comp.Compare);
            //Array.Sort(st, comp.Compare);
            Console.WriteLine("With ICompare");
            for (int i = 0; i < intstudent; i++)
            {
                Console.WriteLine(st[i].ToString());

            }
        }

        public void tests()
        {
            try
            { 
            object myobj = null;
            Console.WriteLine("Start");
            myobj.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
