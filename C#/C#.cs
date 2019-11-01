using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

// method/function called Main
// methods have inputs and outputs
// what goes in paranthesis is the input to the method (which we call parameter or argument)
// in this case, the parameter is named args, which is of type - string array
// what you see before the method name is the return type, or the output of the method
// void in C# means nothing - which means this method does not return any value. It just contains some code, that's it.

using System; (highlighted)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}

// Hello World

// using System is highlighted, while the others are greyed out. The reason for that is we are using a class called Console that is defined in the system namespace. That is why that using System is active. We are not using any classes defined in other namespaces, that is why they are greyed out. So we can get rid of them to make our code cleaner

// Primitive Types

// Variables and Constants
// Variable: a name given to a storage location in memory
// Constant: an immutable value

// in C#, to declare a variable, we start with a type, followed by an identifier, and finally semicolon

int number;
int Number = 1;
const float Pi = 3.14f;

// also note that C# is a case sensitive language

// Identifier Rules:
// Cannot start with a number:
// 1route
// Cannot include a whitespace:
// first name
// Cannot be a reserved keyword:
// int
// Reccomendation: Use meaningful names
// firstName instead of fn 

// Popular Naming Conventions in the C language family
// Camel Case: firstName
// Pascal Case: FirstName
// Hungarian Notation: strFirstName (prefixing the name of a variable, with the data type it uses) - usually not used in C#, but other C programming languages

// For C#, to name your local variables, use Camel Case
// int number;

// For constants, use Pascal Case
// const int MaxZoom = 5;

// Here is a list of most commonly used, primitive types in C# (see screenshot in folder):

// Integral Numbers
// byte
// short
// int
// long

// Real Numbers
// float
// double (default)
// decimal

// Character
// char 

// Boolean
// bool 


// Most of these data types are pretty stragiht forward, but there is something tricky about Real Numbers
// float number = 1.2f; (have to add the suffix f to floats)
// decimal number = 1.2m; (have to add the suffix m to decimals)

// Non-Primitive Types
// String 
// Array 
// Enum 
// Class 

// Overflowing
// byte number = 255; (the largest number you can store in a byte)
// number = number + 1 (trying to store 256 in the number)
// // 0

// you will see zero in the console. This is what we call overflowing. 

// Sometimes this is not desirable in your application. You want to stop overlowing. If that's the case, you need to use the checked keyword

// checked
// {
//     byte number = 255;

//     number = number + 1;
// }

// If you use the checked keyword, overflow will not happen and instead the program will throw an exception

// The topic of exception is an advanced topic, and I have covered it in my C# advanced course

// Now do we really need this in reality? Not really. If you were really worried about overflow, all you would have to do is change your data type to short, or something else. We are just reviewing this so that you are aware of how overflow works

// Scope
// Where a variable/constant has meaning and is accessible

// Take a look at this block of code here:

{
    byte a = 1;

    {
        byte b = 2;

        {
            byte c = 3;
        }
    }
}

// a is acessible anywhere in this block and any of its child blocks. If I go out of this block, and try to access a, the program will not compile. The same rule applies to other variables. b is meaningful anywhere inside its block or anywhere in its children. If I go anywhere else and try to access b, I am going to get a compile error. 


using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number;
            Console.Writeline(number);
        }
    }
}

// If we just write this, we will get a red underline for number in the Console.WriteLine function, stating:
// Local variable number might not be initialized before accessing

// Before you can access a varialbe, you need to set and initialize it. We cannot display the number on the console before initializing it. Therefore, if we try to compile this, we will get an error. 

// We can solve this by the following:

using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}

// 2
// 10
// 20.95
// A
// Mosh
// true

// In C# we have a keyword called var, which makes variable declarations easier. For example, instead of explicitly identifying the data type, you can simply type var and let the C# compiler detect the data type. Then if you hover over var in visual studio, it will give you what data type is being represented.

using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Mosh";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}

using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.minValue, byte.MaxValue);
        }
    }
}
// 0 255

// "{0} {1}" what we have here is called a format string. It is a string that can be used as some sort of template. What we have in the {0} will be replaced by byte.MinValue. So {0} represents the first argument after the format string. And {1} represents the secon argument after the format string. 

// We can do the same thing with floats...

using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", float.minValue, float.MaxValue);
        }
    }
}
// -3.4E+38 3.4E+38

using System;

namespace Variables 
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14f;
        }
    }
}

// Implicit Type Conversion

// byte b = 1;
// int i = b;

// or 

// int i = 1;
// float f = i;

// no data loss is happening in either case

// Explicit Type Conversion

// int i = 1;
// byte b = i;
// won't compile - three out of four bytes will be gone and there is a chance for data loss. And there is a chance for data loss. Now data loss does not always happen, it only happens if the value we stored in the integer is beyond the capacity of the byte

// In this example, 1 can be stored in a byte. So no data loss will happen. But if it had, lets say 300 here, we cannot store 300 in a byte. So as a result of that conversion, data will be lost.

// When the compiler knows that there is a chance for data loss, it doesn't allow implicit type conversion. And you need to explicitly tell the compiler that you are aware of the data loss and you still want to go ahead with the conversion. In situations like that, we prefix the variable with the target type

// int i = 1;
// byte b = (byte)i;

// So here, I am trying to conver i to byte. This is what we know as casting. 

// Here is another example, 

// float f = 1.0f;
// int i = (int)f;