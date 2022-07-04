using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Notes
{
    public class NullExcep
    {
        public static void Main(string[] args)
        {
            //string name = "Nitish Mehta"; /
            //Console.WriteLine(name.Length);
            //Console.ReadLine();
            try
            { 
              string name = null;
              Console.WriteLine(name.Length);
             
            }
            // NullReferenceException:- it's class of exception
            //Message :- Property of exception class to show exception error type.

            catch (NullReferenceException ex) 
            {
                Console.WriteLine("String is null");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }    
}
