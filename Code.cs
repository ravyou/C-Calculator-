using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
                    
public class Program
{
    public class calculator { 
        
        public static void calculate(string num1, string num2, string sample1) {
            int number1 = Int32.Parse(num1);
            int number2 = Int32.Parse(num2);
            int result = 0;
            String check1 = sample1;
            
            if(check1 == "A" || check1 == "a") {
                result = number1 + number2;
                Console.WriteLine("Answer: " + result);
            
            } else if(check1 == "B" || check1 == "b") {
                result = number1 - number2;
                Console.WriteLine("Answer: " + result);
                
            } else if(check1 == "C" || check1 == "c") {
                 result = number1 * number2;
                 Console.WriteLine("Answer: " + result);
                 
            } else if(check1 == "D" || check1 == "d") {
                result = number1 / number2;
                Console.WriteLine("Answer: " + result);
            } 
            
            
           }
            
        
        
        public static void run4(string num1, string num2) {
            Console.WriteLine(" Choose An Option From The Following List: "); 
            Console.WriteLine("\tA = +\n\tB = -\n\tC = *\n\tD = /\n\t");
            String number1 = num1;
            String number2 = num2;
            String check1 = Console.ReadLine();
            if(check1 == "a" || check1 == "b" || check1 == "c" || check1 == "d" || check1 == "A" || check1 == "B" || check1 == "C" || check1 == "D") 
        {
            Console.WriteLine("calculating please wait...");
            Thread.Sleep(1000);
            calculator.calculate(number1, number2, check1);
            
        }   else { 
            calculator.run4(number1, number2);
            
        }
}   
        public static void run3(string num1) { 
            Console.WriteLine("Type Another Number ");
            String number1 = num1;
            String number2 = Console.ReadLine(); 
            bool isNumber2 = int.TryParse(number2, out int n); 
            if(isNumber2 == false)
     { 
            Console.WriteLine("(Error)\n");
            calculator.run3(number1);
            Console.Clear();
     }      else { calculator.run4(number1, number2); }
   } 
    
        public static void run2() {
            Console.WriteLine("Please Enter a Number "); 
            String number1 = Console.ReadLine(); 
            bool isNumber = int.TryParse(number1, out int n); 
            if(isNumber == false)
     { 
                Console.WriteLine("(Error)\n");
                calculator.run2();
                Console.Clear();
      
         
     }      else { calculator.run3(number1);
         
     }
   }
    
    public static void run1() { 
     Console.WriteLine(" Console Calculator in C#\n========================\n\n");
     Console.WriteLine("Type A Number And Press Enter "); 
     String number1 = Console.ReadLine(); 
     bool isNumber = int.TryParse(number1, out int n); 
     if(isNumber == false)
     { 
       Console.WriteLine("(Error)\n");
       calculator.run2();
     } else { calculator.run3(number1); 
         
    }
  }
}

       public static void Main(string[] args) {
        calculator.run1();
    }
}
