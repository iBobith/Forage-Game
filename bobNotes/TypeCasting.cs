// Type Casting

// Type casting is when you assign a value of one data type to another type.
// In C# there are two types of casting:

// Implicit Casting (automatically) - converting a smaller type to a larger size type:
char    ->  int     ->  long    ->  float   ->  double;

int myInt = 13;
double myDouble = myInt;            // Automatic casting: int to double;
System.Console.WriteLine(myInt);    // Outputs: 9
System.Console.WriteLine(myDouble); // Outputs: 9
// Implicit casting is done automatically when passing a smaller size type to a larger size type;

//Explicit Casting (manually) - converting a larger type to a smaller size type:
double  ->  float   ->  long    ->  int     ->  char;

double myDouble = 9.78D;
int myInt = (int) myDouble;         // Manual casting: double to int;
System.Console.WriteLine(myDouble); // Outputs: 9.78
System.Console.WriteLine(myInt);    // Outputs: 9
// Explicit casting must be done manually by placing the type in parentheses in front of the value;

// Type Conversion Methods
/* It is also possible to convert data types explicitly by using built-in methods,
     such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long): */

int myInt = 10;
double myDouble = 5.25D;
bool myBool = true;

System.Console.WriteLine(Convert.ToString(myInt));      // converts int to string;
System.Console.WriteLine(Convert.ToDouble(myInt));      // converts int to double;
System.Console.WriteLine(Convert.ToInt32(myDouble));    // converts double to int;
System.Console.WriteLine(Convert.ToString(myBool));     // converts boolean to string;