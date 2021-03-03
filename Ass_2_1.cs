using System;
public class Practical_assignments_Branchig
 {
  public static void Main()
  {
   Console.Write("Write the day number: ");
   int day = Int32.Parse(Console.ReadLine());
   switch (day)
   {
       case 1: 
       case 2:
       case 3:
       case 4:
       case 5:
         Console.WriteLine("It is a working day.");
         break;
       case 6:
       case 7:
         Console.WriteLine("It is holiday.");
         break;
       default:
       Console.WriteLine("Error!Day is not validate");
         break;
   }
  }
}