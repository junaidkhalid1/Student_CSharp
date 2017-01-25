//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CS2_Student
//{
//    class Tasks
//    {
//        static void Main(string[] args)
//        {

//            Process[] p_list = Process.GetProcesses();
//            int thrd = 0;
//            string note;

//            foreach (Process pr in p_list)
//            {
//                Console.WriteLine("Name: "+pr.ProcessName+" ID: "+pr.Id + " Bytes: " + pr.PrivateMemorySize);
//                thrd = thrd + pr.Threads.Count;
//            }

//            Console.WriteLine("Total Processes:"+p_list.Length);
//            Console.WriteLine("Total Threads:" + thrd);

//            Console.WriteLine("\tEnter Notepad: ");
//            note = Console.ReadLine();

//            if (note == "Notepad")
//            { 
//            System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
//            }
//            else
//            {
//                Console.WriteLine("Please wrtie as 'Notepad': ");
//            }
//            Console.ReadLine();

//        }



//    }
//}