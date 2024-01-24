// Source: https://www.w3schools.com/cs/index.php

using System;   // A C# program to print "Hello World"
                /* By inputting "using System", im using all the system's functions, however there are ways to specify which system to use
                depending on what I'm trying to achieve. */
                    // Meaning we can use classes from the System namespace.

namespace HelloWorld {  // Namespace declaration.
                            // A namespace is used to organize a group related to code elements. 
                            // For example:
                            /*  namespace Game {class Player{} namespace Weapons {class Sword{}   class Gun{} }   }
                                Here there is a namespace "Game" that contains the player class, which belongs to the game,
                                however instead of making many weapon classes in the "Game" namespace, you can create a "weapons" 
                                namespace where you can put all the weapons that are found within the game. */
                            // In conclusion, its like folders within your code for you classes and other code.
    class Program { // Class declaration.
        static void Main(string[] args) {   // Main method.
            Console.WriteLine("Hello World!");  // Console is a class of System; WriteLine() method that used to output/print text.
                                                    // Without the `using System` line, this line would be `System.Console.WriteLine()` instead.
                                                // Printing "Hello World!"
                                                // Running `Console.WriteLine(6 + 6) will produce the calculation.
                                                    // Printing "12" 
            // Console.ReadKey();   // To prevent the screen from running and closing quickly.
            Console.Read();         /*  Instead of using .ReadKey, I should use .Read, otherwise the programme will be waiting for me to hit
                                        a specific key, whereas now it just finishes when I enter anything. */
        }
    }
}

/*  After trying to figure out how to run this code to see my "Hello World!", I had discovered the need for a compiler in order to make 
    my code into an .exe file. So I'm going to look into that, documenting my findings within Compilation.cs */