
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;

//namespace CS2_Student
//{
//    class Thread_Bonjour
//    {

//        public String input = "go";

//        public void func_thread_bonjour(object obj)
//        {

//            Container_Bonjour con = obj as Container_Bonjour;
//            string x =con.s;
//            int p = con.p;

//            while (input != "quit")
//            {
//                Console.WriteLine("Hello!");
//                Thread.Sleep(p);
//                Console.WriteLine(x);

//            }
//        }

//        class Container_Bonjour
//        {
             
//        public string s;
//        public int p;

//        public Container_Bonjour(string s1, int p1)
//        {
//            s = s1;
//            p = p1;
//        }

//        }

//        static void Main(string[] args)
//        {
//            Thread_Bonjour thread_obj = new Thread_Bonjour();
//            EventWaitHandle objAuto = new EventWaitHandle(false, EventResetMode.AutoReset);

//            Thread Myth_b = new Thread(new ParameterizedThreadStart(thread_obj.func_thread_bonjour));
//            objAuto.Set();
//            Myth_b.Start(new Container_Bonjour("Bonjour!", 1000));
//            objAuto.WaitOne();

//            while (thread_obj.input != "quit")
//            {
//                thread_obj.input = Console.ReadLine();

//            }

//            Console.ReadLine();

//        }

//    }
//}
