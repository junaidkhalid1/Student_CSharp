﻿using System;
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
            /*

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

            /*
            Array.Sort(st);
            for (int i = 0; i < input; i++)
            {
               
                Console.WriteLine(st[i].ToString());

            } 

            */
            Comparer cp = new Comparer();

            cp.display();

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
