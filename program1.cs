using System;

class Program1
{
	static void Main( )
	{
        int a;      // Allocate memory to store an integer number named a
        double b;   // Allocate memory to store a real number named b
        string c;   // Allocate memory for a text string named c
        bool d;     // Allocate memory for a Boolean value named d

		Console.WriteLine( "Program 1" );
		Console.WriteLine( "Simple Types Example Program" );

		a = 5;              // Assign a numeric literal value of 5 to a
		b = 5.3d;           // Assign a numeric literal value of 5.3 to b
		c = "Hello World";  // Assign a string literal value of "Hello World" to c
		d = true;           // Assign a Boolean literal value of True to d

		Console.WriteLine( a );     // Output a to the console
		Console.WriteLine( b );     // Output b to the console
		Console.WriteLine( c );     // Output c to the console
		Console.WriteLine( d );     // Output d to the console
	}
}
