using System;

namespace username {
    class myProgram {
        static void Main(string[] args) {
            
            Console.WriteLine("Enter Username:");           
            string? userName = Console.ReadLine();          // Adding a `?` after the variable type changes it to a nullable variable.
                                                            // Nullable error solved.     

            Console.WriteLine("Username is: " + userName);  
        }
    }
}