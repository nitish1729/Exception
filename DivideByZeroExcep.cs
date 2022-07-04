// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine("Enter 1st number");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter 2st number");
//int num2 = int.Parse(Console.ReadLine());1
//int result = num1 / num2;  // exception can occur here
// if user enter num2 = 0 then DivideByZeroException will occur
//Console.WriteLine("Your result is : " + result);
//string exception = "exception is an event/action in c# that result " +
//    "stop the excection of progrm";
//Console.WriteLine(exception);
// In C# try & catch are two keyword to handle the exception
//
// try block:- Any suspected code that may raise exception should put inside the 
//             try block{}. if during the execution , if an exception occurs then
//             flow of control jumps to the first matching block.

// Catch block:- The catch block is an exception handler block where you can perform
//               some action such and logging and auditing an exception. The catch block 
//takes parameter of an exception type using which you can get the details
//of exception.



Console.WriteLine("Enter a number: "); // enter non-numeric value to see the exception
var num = int.Parse(Console.ReadLine());
try
{
    //Console.WriteLine("Enter a number: ");

    //var numb = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Squre of {num} is {num * num}");
}
catch (FormatException ex1)
{
    Console.Write("Enter numeric value .");
    Console.WriteLine(ex1.Message);
}
//finally
//{
//    Console.Write("Re-try with a different number.");
//}



Console.WriteLine("Enter 1st number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2st number");
int num2 = int.Parse(Console.ReadLine());
try
{
    int result = num1 / num2;  // exception can occur here(if num2 =0)
    Console.WriteLine("Your result is : " + result);
}
// catch block work if exception will occurs in try block otherwise program jump to next statement.
catch (DivideByZeroException ex)
{
    Console.WriteLine("You can not divide by zero");
    // Message is property i C# Which display exception error Message
    Console.WriteLine(ex.Message);
}

string exception = "exception is an event/action in c# that result " +
    "stop the excection of progrm";
Console.WriteLine(exception);
Console.WriteLine("........................................");
Console.WriteLine("Exception types ");
string types = "SystemException,ApplicationException ";
Console.WriteLine(types + "Here SystemException");
Console.WriteLine("IndexOfRangeException");
Console.WriteLine("NUllreferenceException");
Console.WriteLine("DivideByZeroExpection");
Console.WriteLine("ArgumentException");
Console.WriteLine("OverflowException");
Console.WriteLine("AggregateException");



//Divide by zero:-  is the System. DivideByZeroException, 
//    which is a class 
//    that handles errors generated from dividing a dividend with zero
Console.ReadLine();