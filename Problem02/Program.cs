﻿using System;
using System.Threading;

namespace Problem02
{
    class Program{
        private static string x ="";
        private static int exitflag = 0;
        private static int flag = 0;
        private static object _Lock = new object();

        static void ThReadX()
        {            
            while(exitflag==0)
            {
                if(flag ==1){
                    Console.WriteLine("X = {0}", x);
                    flag = 0;
                }
                
            }
        }
        static void ThWriteX()
        {
            string xx;
            while(exitflag == 0)
            {
                if(flag == 0){
                
                Console.Write("Input: ");
                xx = Console.ReadLine();
                if(xx == "exit"){
                    exitflag = 1;
                    Console.Write("Thread 1 exit");}
                else
                    x = xx;
                    flag = 1;
                }
            }
        }

        static void Main(string[] args)
        {
            Thread A = new Thread(ThReadX);
            Thread B = new Thread(ThWriteX);
            
            A.Start();
            B.Start();
            
            
            
        }
    }
}