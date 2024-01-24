// C# Data Types

// As explained in the variables chapter, a variable in C# must be a specified data type:
int myNum = 5;                  // Integer (a whole number)
double myDoubleNum = 5.99D;     // Floating point number (decimal)
char myLetter = 'D';            // Character
bool myBoolean = false;         // Boolean
string myText = "Hello!";       // String

// A data type specifies the size and type of variable values.
/* It is important to use the correct data type for the corresponding variable; to avoid errors, save time and memory, but it will also make
    your code more maintainable and readable. The most common data types are: */
int     // 4 bytes                  Stores whole numbers from -2,147,483,648 to 2,147,483,647;
long    // 8 bytes                  Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807;
float   // 4 bytes                  Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits;
double  // 8 bytes                  Stores fractional numbers. Sufficient for storing 15 decimal digits;
bool    // 1 bit                    Stores true or false values;
char    // 2 bytes                  Stores a single character/letter, surrounded by single quotes;
string  // 2 bytes per character    Stores a sequence of characters, surrounded by double quotes;

// Numbers
/* Number types are divided into two groups:
    1) Integer types stores whole numbers, positive or negative, without decimals. Valid types are `int` and `long`. Which type you should
        use, depends on the numeric value.
    2) Floating point types represent numbers with a fractional point, containing one or more decimals. Valid types are `float` and `double`.*/

// Integer 
// `int`
int myNum = 10000;
System.Console.WriteLine(myNum);
// `long`
long myNum = 15000000000L;          // Note that you should end `long` values with an 'L';
System.Console.WriteLine(myNum);

// Floating point types
// You should use a floating point type whenever you need a number with a decimal, like -9.1872 and 5.090144.
// `float`
float myNum = 3.99F;                // Note that you should end `float` values with an 'F';
System.Console.WriteLine(myNum);
// `double`
double myNum = 19.99D;              // Note that you should end `double` values with a 'D';
System.Console.WriteLine(myNum);

// It's safer to use `double` for most calculations, since its more precise (down to 15 decimals), than `float`.
// Scientific Numbers
float f1 = 13e5F;
double d1 = 13e14D;
System.Console.WriteLine(f1, d1);
// You can also write numbers with scientific notation using `float` and `double`.

// Booleans 
// A boolean data type is declared with the bool keyword and can only take the values `true` or `false`:
bool isCSharpFun = true;
bool isLeagueFun = false;
System.Console.WriteLine(isCSharpFun);
System.Console.WriteLine(isLeagueFun);

/* Characters and strings are self explanatory - I don't feel like I need to cover those much more, at the moment. */