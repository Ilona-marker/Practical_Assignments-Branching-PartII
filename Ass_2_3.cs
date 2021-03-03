using System;
public class Assignments_Branchig
 {
  public static void Main()
  {
      Console.Write("Write the first number: ");
      int number1 = Int32.Parse(Console.ReadLine());
      Console.Write("Write the second number: ");
      int number2 = Int32.Parse(Console.ReadLine());
      Console.Write("Possible operation are:'+','-','/','*','%' get remainder,'p' print elements,'b' bigger,'s' smaller\n");
      Console.Write("Enter the operation: ");
      char type = Char.Parse(Console.ReadLine());
      switch (type) {
          case '+':
          Console.WriteLine($"Sum both elements is {number1 + number2}");
          break;
          case '-':
          Console.WriteLine($"Substraction both elements is {number1 - number2}");
          break;
          case '/':
          Console.WriteLine($"Dividing both elements is {(double)number1 / number2}");
          break;
          case '*':
          Console.WriteLine($"Multiplication both elements is {number1 * number2}");
          break;
          case '%':
          Console.WriteLine($"Remainder dividing both elements is {(double)number1 / number2}");
          break;
          case 'p':
          Console.WriteLine($"Print out both elements: {number1} and {number2}");
          break;
          case 'b':
          Console.WriteLine($"The bigger number is {Math.Max(number1, number2)}.");
          break;
          case 's':
          Console.WriteLine($"The smaller number is {Math.Min(number1, number2)}.");
          break;
          default:
          Console.WriteLine("The operation is not known is invalide");
          break;
      }
   }
 }