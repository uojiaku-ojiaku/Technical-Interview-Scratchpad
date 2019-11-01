// STRINGS
Console.WriteLine("Hello World"); //-- writes a line of text onto the screen 
Console.ReadLine(); -- keeps console window open 
Console.WriteLine("There once a man named " + characterName); //-- concatenation with a string and variable
Console.WriteLine("He was " + characterAge + " years old");
Console.WriteLine("Giraffe\nAcademy"); //-- \n makes a new line
Console.WriteLine("Giraffe\"Academy"); //-- writing \ before " allows you to write a quotation mark in your string without messing up the code
string phrase = "Giraffe Academy";
Console.WriteLine( phrase.Length); //-- should tell me how much characters are inside of this string

// we can also use methods on our strings...
string phrase = "Giraffe Academy";
Console.WriteLine( phrase.ToUpper() ); //-- converts string to uppercase
Console.WriteLine( phrase.ToLower() ); //-- converts string to lowercase
Console.WriteLine( phrase.Contains("Academy") ); //-- this method will return a true or false value telling me whether or not the phrase Giraffe Academy contains the word Academy
Console.WriteLine( phrase[0] ); //-- will tell me what the first character is on the string
Console.WriteLine( phrase.IndexOf("Academy") ); //-- this tells me at what index place the word academy starts
Console.WriteLine( phrase.Indexof('f') ); //-- this will tell ne the location of the first f inside of the string
Console.WriteLine( phrase.Substring(8)); //-- will print out character starting at 8 and the rest of the string after that character
Console.WriteLIne( phrase.Substring(8, 3)); //-- this means you want to start at the eigth index and grab three characters as well after that


// NUMBERS 
Console.WriteLIne( -5.783 );
Console.WriteLine ( 50 );
Console.WriteLine ( 5 + 8 ); //-- C sharp will perform the operationa and output the value
Console.WriteLine ( 5 - 8 ); //-- C sharp will perform the operationa and output the value
Console.WriteLine ( 5 / 8 ); //-- C sharp will perform the operationa and output the value
Console.WriteLine ( 5 * 8 ); //-- C sharp will perform the operationa and output the value
Console.WriteLine ( 5 % 2 ); //-- 5 mod 2. This is a modulus operator. What it's going to do is take 5 and divide it by 2 and then give us the remainder
// 5 divided by 2 is 2 with the remainder of 1. So 1 is going to be the output of this command line
Console.WriteLine( 4 + 2 * 3 ); //-- because of order of operations, the multiplication is going to happen first and then the addition afterwards
// but if I wanted to change the usual order of operations, I could use paranthesis
Console.WriteLine( (4 + 2) * 3);
Console.WriteLine( 5.0 + 8.1 ); //-- performing an operation with two decimals, outputs a decimal as a result
Console.WriteLine( 5 + 8.1 ); //-- performing an operation with an integar and a decimal, output a decimal as well as a result
Console.WriteLine( 5 / 2 ); //-- performing an operation with two integers, always gives an integer back. Any math operation you do with integers will no matter what give an integer back
// the output of the above line would show 2 
// but if you were to convert one of the integers into a double, then you would get a decimal output back
Console.WriteLine( 5 / 2.0 );
// 2.5 (would be the output)
Console.WriteLine("43" + "56");
// 4356
// adding two strings, just concatenates the strings. It does not convert the numbers into integers and then add
int num = "45"; // ERROR. C sharp will not let this work because you cannot store a string in an integer variable. SO we need to convert this string into an integer
int num = Convert.ToInt32("45"); //-- the string has to be a number. If it was "sdlfhs" or "56ksdf", we would still get an error and it wouldn't work. 
Console.WriteLine(num + 6);
// 51

int num = 6;
Console.WriteLine( num );
// 6
int num = 6;
num++;
Console.WriteLine( num );
// what this operation does is add 1 to the number. 
// 7 
num--;

// you can also call math methods on numbers...
Console.WriteLine( Math.Abs(-40) ); //-- gives the absolute value of negative 40, which is positive 40
Console.WriteLine( Math.Pow(3, 2) ); //-- this method stands for power. This line would mean 3 raised to the second power. Which would output 9
Console.WriteLine( Math.Pow(3.8, 2) ); //-- this can also work with decimals
Console.WriteLine( Math.Pow(3, 2.3) );
Console.WriteLine( Math.Sqrt(36) ); //-- this stands for square root. The output will be 6
Console.WriteLine( Math.Max(4, 90) ); //-- this will give us an output for which value is the largest. Outpout will be 90
Console.WriteLine( Math.Min(4, 90) ); //-- does the opposite. Outpout will be 4
Console.WriteLine( Math.Round(4.3) ); //-- rounds the number to the nearest whole number



