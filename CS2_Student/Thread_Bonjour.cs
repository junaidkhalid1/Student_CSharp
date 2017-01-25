
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS2_Student
{
    class Thread_Bonjour
    {
        public string s;
        public int p;

        public Thread_Bonjour(string s1, int p1)
        {
            s = s1;
            p = p1;
        }

        class Threads_Hello
        {
            public String input = "go";

            public void func_thread_bonjour(object obj)
            {

                Thread_Bonjour con = obj as Thread_Bonjour;
                string x = (obj as Thread_Bonjour).s;
                int p = (obj as Thread_Bonjour).p;

                while (input != "quit")
                {
                    Console.WriteLine("Hello!");
                    Thread.Sleep(p);
                    Console.WriteLine(x);

                }

            }

        }

        static void Main(string[] args)
        {
            Threads_Hello thread_obj = new Threads_Hello();

            Thread Myth_b = new Thread(new ParameterizedThreadStart(thread_obj.func_thread_bonjour));
                Myth_b.Start(new Thread_Bonjour("Bonjour!", 1000));
                Console.ReadLine();

        }

    }
}