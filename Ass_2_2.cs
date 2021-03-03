using System;
public class Practical
 {
  public static void Main()
  {
   Console.Write("Write the grade level: ");
   char grade = Char.Parse(Console.ReadLine().ToUpper());
   switch (grade) {
       case 'A':
       case 'B':
       Console.WriteLine("Perfect! You are so clever!");
       break;
       case 'C':
       Console.WriteLine("Good! But You can do better!");
       break;
       case 'D':
       case 'E':
       Console.WriteLine("It is not good! You should study!");
       break;
       case 'F':
       Console.WriteLine("Fail! You need to repeat the exam!");
       break;
       default:
       Console.WriteLine("Error!Grade is invalide");
       break;
     } 
   }
 }