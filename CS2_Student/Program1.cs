//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CS2_Student
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Comparer cp = new Comparer();
//            TestDelegate td = new TestDelegate();
//            Threads_Hello thread_obj = new Threads_Hello();

//            //cp.display();
//            //cp.tests();
//            //td.delegates();
//            //Thread Myth = new Thread(new ThreadStart(thread_obj.func_thread));
//            //Myth.Start();

//            //while (thread_obj.input != "quit")
//            //{
//            //    thread_obj.input = Console.ReadLine();
//            //}
            
//            Thread Myth_b = new Thread(new ParameterizedThreadStart(thread_obj.func_thread_bonjour));
//            Myth_b.Start(new Thread_Bonjour("Bonjour",1000));
//            while (thread_obj.input != "quit")
//            {
//                thread_obj.input = Console.ReadLine();
//            }

//            //Thread Myth_b = new Thread(new ThreadStart(thread.func_thread_bonjour));
//            //Myth_b.Start();

//            //while (thread.input != "quit")
//            //{
//            //    thread.input = Console.ReadLine();
//            //}

//            //thread.func_thread();

//            Console.ReadLine();

//        }



//    }



//    //TO make non static
//    /*
//    maincalls myprog
//        myprog = new maincalls
//        myprog.start();
//        */
//}