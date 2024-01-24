/* You have already learned that Console.WriteLine() is used to output (print) values. 
    Now we will use Console.ReadLine() to get user input.

    In the following example, the user can input his or hers username, which is stored in the variable userName.
    Then we print the value of userName: */

using System;

namespace username {
    class program {
        static void Main(string[] args) {
            Console.WriteLine("Enter Username:");           // Type your username and press enter;

            string userName = Console.ReadLine();           // Create string variable and get user input from keyboard and store it in the variable;

            Console.WriteLine("Username is: " + userName);  // Print the value of the variable (userName), which will display the input value;
        }
    }
}

// Then I use `dotnet publish -c Release -r linux-x64` to create the .exe, rather the .deb file for this code.