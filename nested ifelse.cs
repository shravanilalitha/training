/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("enter value for a");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter value for b");
      int b = Convert.ToInt32(Console.ReadLine());
      if(a==b)
      {
          Console.WriteLine("both are equal " + " " + a );
          
      }
      else if(a<b)
      {
          Console.WriteLine("a is lessthan b" + " " + b);
      }
      else if(a>b)
      {
          Console.WriteLine("a is greater than b" + " "  + a);
      }
    Console.WriteLine("Thank You");
  }
}