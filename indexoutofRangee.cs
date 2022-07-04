using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_notes
{
    public class indexoutofrangee
    {
        public static void Main(string[] args)

        {
            int[] arr = new int[3]; //{ 10, 20, 30 };
            try
            {
                arr[0] = 10;
                arr[1] = 20;
                arr[2] = 30;
                arr[3] = 40;


                //foreach loop, which is used exclusively to loop through elements in an array:
                //foreach (type variablename in arrayname)
                //{
                //    // code block to be executed
                //}
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("array range is exceeded..");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
