 using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using System.Xml.Linq;

namespace LAB1 { 
public class Task
    {
        public int Value1;
        public int Value2;
        public int Sum;
        public int doubleSum;
        public void DoubleSum() { 
         Sum = Value1 + Value2;
         doubleSum = (Value1 + Value2) * (Value1 + Value2) * (Value1 + Value2);
         Console.WriteLine("Double Sum: " + doubleSum);
        }
    }

    class Program { 
    static void Main(string[] args)
    {
        Console.WriteLine("lab 1. Choose task: ");
        Console.WriteLine("1. Task 1");
        Console.WriteLine("2. Task 2");
        Console.WriteLine("3. Task 3");
        Console.WriteLine("4. Task 4");
        Console.WriteLine("5. Task 5");
        Console.WriteLine("6. Task 6");
        Console.WriteLine("7. Exit");

        int choice;
        bool isValidChoice = false;

        do
        {
            Console.Write("Enter number of task :");
            isValidChoice = int.TryParse(Console.ReadLine(), out choice);

            if (!isValidChoice || choice < 1 || choice > 7)
            {
                Console.WriteLine("Error");
                isValidChoice = false;
            }
        } while (!isValidChoice);

        switch (choice)
        {
            case 1:
                task1();
                break;
            case 2:
                task2();
                break;
            case 3:
                task3();
                break;
            case 4:
                task4();
                break;
            case 5:
                task5();
                break;
            case 6:
                task6();
                break;
            case 7:
                break;
        }
    }
 static void task1()
{
    Console.Write("Enter L :");
    string? str = Console.ReadLine();
    float L = 0; 
    if (str != null) L = float.Parse(str);
    double R = L/(2*Math.PI);
    Console.WriteLine("R = " + R);
}
   
 static void task2()
{
     Console.Write("Enter the 3-digit value: ");
        string? val = Console.ReadLine();
        if (val[0] > val[2]) Console.WriteLine("bigger digit is a first one: " + val[0]);
        if (val[0] == val[2]) Console.WriteLine("=");
        if (val[0] < val[2]) Console.WriteLine("bigger digit is a last one: " + val[2]);


        if (val.Length != 3 || !int.TryParse(val, out int number))
        {
            Console.WriteLine("Error. Enter the 3-digit value! ");
            return;
        }
}
 static void task3()
 {
    Console.WriteLine("Find out where the point is...");

    Console.WriteLine("Enter the x :");
    float x = float.Parse(Console.ReadLine());

    Console.WriteLine("Enter the y :");
    float y = float.Parse(Console.ReadLine());;

   if((x > y && x < 70) || (x < y && x > 70))
   {
    Console.WriteLine("yes");
   }
   else if(y == x || x == 70)
   {
    Console.WriteLine("on the lim");
   }
   else 
   {
    Console.WriteLine("no");
   }



 }

 static void task4()
 {
    Console.Write("Enter the grade (0-100):");
    int n = int.Parse(Console.ReadLine());

    string defination;
     if (n < 50)
        {
            defination = "unsatisfactorily";
        }
        else if (n < 70)
        {
            defination = "satisfactorily";
        }
        else if (n < 90)
        {
            defination = "well";
        }
        else if (n <= 100 )
        {
            defination = "excellent";
        }
        else
        {
            defination = "Error!";
        }

        Console.WriteLine($"Age category: {defination}");
    }
  
  static double SquereOfSum(double x, double y) {
    double Sum = x + y;
    double SquereOfSum = Sum * Sum ;
    return SquereOfSum;
  }

  static void task5()
 {
    Console.Write("Enter the x:");
    double x = double.Parse(Console.ReadLine());

    Console.Write("Enter the y :");
    double y = double.Parse(Console.ReadLine());;

    double result = SquereOfSum(x, y);
    Console.Write($"(x+y)^2 = {result}");

 }

  static void task6()
 {
    Console.WriteLine("Enter x:");
    double x = double.Parse(Console.ReadLine());
    
    Console.Write("Enter the y :");
    double y = double.Parse(Console.ReadLine());;

    double result = ((y*y + 4)/(x*x + 2*x + 5) + 1)*x;

    Console.WriteLine($"Result of expression: {result}");
 }
    }

}
