using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Notes
{
  public class DivideByZeroo
  {
    public static void Main() 
    {
            //     int a = 10;
            //     int b = 0;
            //     try
            //     {
            //         int c = a / b;
            //         Console.WriteLine(c);
            //     }
            //     catch (Exception ex)
            //     {
            //         Console.WriteLine("Divied by zero is not possible");
            //         Console.WriteLine(ex.Message);
            //     }

        int account_balance = 5000;
        Console.WriteLine("Enter your withdrwal amount");
         int withdrwal_amount = int.Parse(Console.ReadLine());
       try 
       {
         if (account_balance < withdrwal_amount)
         {
          throw new Exception("insufficient balnce");
         }
          else
          {
           account_balance = account_balance - withdrwal_amount;
           Console.WriteLine("remaining balance is : " + account_balance);
           Console.WriteLine("Transaction completed successfully..");

          }
       }
         catch(Exception ex) 
         {
                Console.WriteLine(ex.Message);
         }
            Console.ReadLine();
    }
  }
}
