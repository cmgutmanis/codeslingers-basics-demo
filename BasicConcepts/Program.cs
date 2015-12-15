using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment. It is only here for the programmers to better understand what is happening in the code.
            // It will not be run by the program itself, think of it as just annotations to the program.

            // Regions basically are used for organization. Inside of Visual Studio, you can show or hide region-level blocks of code as needed.
            #region helloworld
            /* This is the traditional first program beginners learn. It merely outputs the string (more on that later)
             * "Hello world!" to an output. In this case, it is the console window and the monitor screen, but it could be 
             * any number of things -- a web page, writing to an excel file, printing out on a printer.
             * 
             * Oh yeah, this is a block comment. For long-winded comments where you don't want to put the two leading slashes 
             * on every line, you can start with /*. To end the comment just type */
            // You don't need to start every line with a star. Visual Studio just does that.
            Console.WriteLine("Hello World!");
            #endregion

            #region datatypes, variables, and input
            // Integer data type. Can represent any whole number between -2,147,483,648 to 2,147,483,647
            // Intermediate topics: long, short, unsigned, byte.
            
            // Variable declaration: the first keyword is the variable 'type' - in this case, type of int (Integer). 
            // The second word is the 'name' you use to reference it. It is good practice to give it a name that easily identifies what the value is used for.
            // The single = sign is the assignment operator. It represents the word 'is' in English.
            // The fourth part is the assigned value. This tells the program what value to use when it comes to this variable.
            // The ending semicolon is part of the C# language. It tells the compiler that this statement is done.
            int displayValue = 5;
            // Now, instead of typing Console.WriteLine(5); We can use the variable. This is particularly helpful if the value can change or we do not know what it will be when we are programming.
            Console.WriteLine(displayValue);
            // changing this value is incredibly easy. We can do normal assignment - displayValue = 6; or we can do math on it as well.
            displayValue = 6 + 3;
            Console.WriteLine(displayValue);

            // We can also do math on variables;
            int firstValue = 3;
            int secondValue = 2;
            int thirdValue = firstValue - secondValue;
            Console.WriteLine(thirdValue);

            // Here are some other variable types.
            double doubleExample = 4.6; // this is used for numbers with decimal points. There is also a type 'decimal' to be used if you need a large amount of numbers after the decimal point.
            // resource on ranges and guide for which datatype to use in different scenarios:
            // https://social.msdn.microsoft.com/Forums/vstudio/en-US/921a8ffc-9829-4145-bdc9-a96c1ec174a5/decimal-vs-double-difference?forum=csharpgeneral

            char charExample = 'r'; // This is used for a single character. Usually could be used for something like y/n inputs.
            string stringExample = "Hello!"; // Used for any number of characters. Can be used for letters, numbers, punctuation.

            Console.WriteLine("Type some stuff!");
            string myString = Console.ReadLine();
            Console.WriteLine("You entered: ");
            Console.WriteLine(myString);

            // It is worth noting that C# is a type-safe language. That means once an item is created as a given type, you cannot simply assign a different type on the original variable.
            // intermediate topics: casting as types.

            /* Uncomment this to see compiler errors when trying to build.
            int integerValue = 5;
            integerValue = "Now I'm a string!"; */

            #endregion

            #region flow control: conditional logic
            // We want the user to enter a number and then determine if their number is odd or even. To this, we use if/else logic.
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine()); // Type conversion. ReadLine() input is a string type. Here, we do a conversion to integer datatype
                                                           // intermediate: TryParse and out parameters.

            if (num % 2 == 0)
            { // check to see if number divisible by 2 has no remainder (even number). % operator does division and determines remainder.
                // == sign represents "is equal to" != represents "is not equal to". Others: < (less than), <= (less than or equal to), > (greater than), >= (greater than or equal to)
                Console.WriteLine("Even!");
            }
            else // if the evaluated condition is not true
            {
                Console.WriteLine("Odd!");
            }

            // You can chain if/else statements together. 
            Console.Write("Enter another number: ");
            int anotherNumber = Convert.ToInt32(Console.ReadLine());
            if (anotherNumber < 10)
            {
                Console.WriteLine("Small!");
            }
            else if (anotherNumber < 50)
            {
                Console.WriteLine("Medium size!");
            }
            else
            {
                Console.WriteLine("Big!");
            }

            // intermediate: switch/case

            #endregion

            #region flowcontrol: loops
            // Many times you wish to spin through and perform a given action 2, 5, 1000 times in a row, for example, displaying all people in a list.
            // You could do Console.WriteLine(1); Console.WriteLine(2); ... Console.WriteLine(1000);, but that would be far too much work.

            // When you know how many times you are going to execute a given action, a for loop is a good choice. 
            // Syntax: for (startCounter, endCondition, counterModifier)
            // In this case, the start value is 1, the loop will execute as long as the value is less than or equal to 10, and the value will increment by 1 every time.
            // example of not incrementing the value: http://www.codewars.com/kata/unfinished-loop-bug-fixing-number-1

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            }

            #endregion
        }
    }
}
