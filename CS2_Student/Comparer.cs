using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CS2_Student
{
    //[Serializable]
    public class Comparer
    {

        public void display()
        {



        //[XmlArray("st")]
        //[XmlArrayItem("Student")]
            List<Student> st;
            int intstudent;
            string enter;

            //Console.WriteLine("How many students: ");
            //intstudent = int.Parse(Console.ReadLine());
            //Student[] st = new Student[intstudent];


            st = new List<Student>();

            //Deserialize

            XmlSerializer xd = new XmlSerializer(typeof(List<Student>));
            using (StreamReader rd = new StreamReader("students.xml"))
            {
                st = xd.Deserialize(rd) as List<Student>; //deserialize
            }

            //for (int i = 0; i < intstudent; i++)
            //{

            //    //st[i] = new Student();
            //    st.Add(new Student());

            //    Console.WriteLine("Type name: ");
            //    enter = Console.ReadLine();
            //    st[i].name = enter;

            //    Console.WriteLine("Type score: ");
            //    enter = Console.ReadLine();
            //    st[i].score = int.Parse(enter);

            //}
            st.Sort();
            //Array.Sort(st);
            //For Serilzation and others
            //for (int i = 0; i < 2; i++)
            //{

            //    Console.WriteLine(st[i].ToString());

            //}

            //For deserialization
            foreach (Student s in st)
            {

                Console.WriteLine(s.ToString());


            }

            //Serialize

            //XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            //using (StreamWriter wr = new StreamWriter("students.xml"))
            //{
            //    xs.Serialize(wr, st); // Serialize the array
            //}




            Student comp = new Student();
            //st.Sort(st, comp.Compare);
            //Array.Sort(st, comp.Compare);
            Console.WriteLine("With ICompare");
            //for (int i = 0; i < intstudent; i++)
            //{
            //    Console.WriteLine(st[i].ToString());

            //}
        }

        public void tests()
        {
            object myobj = null;
            try
            {
                try
                {
                    int b=6;
                    int a = b / 0;
                }
                finally
                {
                    Console.WriteLine("First finally");
                }
            myobj.ToString();
            }
            catch (System.NullReferenceException)
            {
                myobj = "Hello";
                myobj.ToString();
                Console.WriteLine("Fine");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Inside Finally");
            }
        }
    }
}
