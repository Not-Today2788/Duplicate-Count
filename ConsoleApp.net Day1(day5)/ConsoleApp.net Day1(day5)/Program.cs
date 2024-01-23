using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.net_Day1_day5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5,4,4,5,3,7,5,6,4,3,3,0,6,6,5,8,9,4,6,8 };
            //int[] numcheck = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //int one=0, two=0, three = 0, four = 0, five = 0, six = 0,x seven = 0, eight = 0, nine = 0,zero=0;

            for(int i = 0; i <= 9; i++) 
            {
                int count = 0;
                for(int j = 0; j < 24; j++)
                {
                    if (i == num[j])
                    {
                        count++;
                        
                    }

                    
                }
                Console.WriteLine(i + ": " + count);
            }
                

            
            /*Console.WriteLine("one: " + one);
            Console.WriteLine("two: " + two);
            Console.WriteLine("three: " + three);
            Console.WriteLine("four: " + four);
            Console.WriteLine("five: " + five);
            Console.WriteLine("six: " + six);
            Console.WriteLine("seven: " + seven);
            Console.WriteLine("eight: " + eight);
            Console.WriteLine("nine: "+ nine);
            Console.WriteLine("zero: "+ zero);*/
            Console.ReadLine();
            

        }
    }
}
