/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int a =-1; 
      int b = 10;
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
    Console.WriteLine("Hello World");
  }
}