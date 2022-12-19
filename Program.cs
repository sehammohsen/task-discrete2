using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class perfect_number 
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("please enter the smallest number");
            int smallestnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the biggest number");
            int biggestnumber = int.Parse(Console.ReadLine());
            for (; smallestnumber<biggestnumber;smallestnumber++)
            {
                int sum = 0;
                for (int i = 1 ;i < smallestnumber;i++)
                {
                    if (smallestnumber% i == 0)
                    {
                        sum = sum + i;
                        
                    }
                }
                
                if (sum == smallestnumber)
                {
                  Console.WriteLine("number" + smallestnumber + "is perfect");
                }
                // project 2 perfect number 
            }
            
        }
       
    }
}
