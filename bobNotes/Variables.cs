// Variables
// Source: https://www.w3schools.com/cs/cs_variables.php 

// Variables are containers for storing data values.
// In C# there are different types of variables, defined with different keywords:
    // int      - stores integers (whole numbers);
    // double   - stores floating point numbers (with decimals);
    // char     - stores single characters. Char values are surrounded by 'single quotes';
    // string   - stores text, such as "Hello World!". String values are surrounded by "double quotes";
    // bool     - stores value with two states: true or false;

// Syntax: `type variable = value;`
string name = "John Doe";
System.Console.WriteLine(name);         // Prints "John Doe";
// Keep in mind I'm using `System.` before my `Console.WriteLin()` because this file doesn't have a `using System` line anywhere;

int myNum1 = 15;
System.Console.WriteLine(myNum1);       // Prints "15";
// Or, another way to write this same code:
int myNum2;
myNum2 = 15;
System.Console.WriteLine(myNum2);       // Prints "15";
// However, this is also a possibility:
int myNum3 = 15;
myNum3 = 20;    // This overrides the previous value;
System.Console.WriteLine(myNum3);       // Prints "20";

int myNumber = 13;
double myDecimal = -2.2D;
char myCharacter = 'R';
bool myBoolean = true;
string myString = "Variables!";


// Constants
// Source: https://www.w3schools.com/cs/cs_variables_constants.php 

// If you don't want others (or yourself) to override existing values, you can add the `const` keyword in front of the variable type.
// This will declare the variable as a "constant", which means unchangeable and read-only:
const int myConstantNumber = 15;
myConstantNumber = 20;  // error
                        // This does not override the initial value;

// A common constant to set is PI.


// Display Variables
// Source: https://www.w3schools.com/cs/cs_variables_display.php 

// The `WriteLine()` method is often used to display variable values in the console window.
// To combine both text and variable, use the `+` character:
string name = "John";
Server.Console.WriteLine("Hello, " + name);      // Prints "Hello, John"  
// You can also use it to add two variables together:
string firstName = "John";
string lastName = "Doe";
Server.Console.WriteLine(firstName + lastName); // Prints "John Doe";
// Another way to do this is:
string fullName = firstName + lastName;
Server.Console.WriteLine(fullName);             // Prints "John Doe";

// For numeric values, the `+` character works as a mathematical operator, since we use the `int` variables here:
int x = 5;
int y = 10;
Server.Console.WriteLine(x + y);                // Prints "15";


// Multiple Variables
// Source: https://www.w3schools.com/cs/cs_variables_multiple.php 

// To declare a variable of the same type more than once, you can use commas:
int x = 3, y = 9, z = 13;
System.Console.WriteLine(x + y + z);            // Prints "25";
// You can also assign the same value to multiple variables in one line:
int x, y, z;
x = y = z = 25;
System.Console.WriteLine(x + y + z);            // Prints "75";


// Identifiers
// Source: https://www.w3schools.com/cs/cs_variables_identifiers.php 

/* All C# variable must be identified with unique names. These unique names are called identifiers.
    Identifiers can be short names, like x, y and z, or more descriptive names, like age, day, timeOfDay.
    It is recommended to use descriptive names to make your code more understandable */
// A good example:
int minutesPerHour = 60;

// OK, but not so good example:
int m = 60;

// Note that reserved words in C#, like int or double cannot be used as an identifier.