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
      
      int c;
      if(a<0 && b<0)
      {
          Console.WriteLine("both a and b are negative");
      }
      else if (a<0  || b<0)
      {
          Console.WriteLine("one number is negative");
      }
      else
      {
          Console.WriteLine("both numbers are positive");
      }
    Console.WriteLine("Thank You");
  }
}