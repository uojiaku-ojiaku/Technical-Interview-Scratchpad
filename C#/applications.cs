// GETTING USER INPUT
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine() -- goes off to a new line
        Console.Write("Enter your name: "); // -- does not go off to a new line
        string name = Console.ReadLine(); //-- stores the line of text that the user enters as a string
        Console.WriteLine("Hello " + name);


        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: "); 
        string name = Console.ReadLine(); 
        Console.Write("Enter your age: ");
        string age = Console.ReadLine(); 
        Console.WriteLine("Hello " + name + " you are " + age + " years old");
        

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 + num2);
        

        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter another number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(num1 + num2);
        

        Console.ReadLine();
    }
}
// Allows application to handle decimal user inputs



class Program
{
    static void Main(string[] args)
    {
        string color, pluralNoun, celebrity;

        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        Console.Write("Enter a plural noun: ");
        pluralNoun = Console.ReadLine();

        Console.Write("Enter a celebrity: ");
        celebrity = Console.ReadLine();

        Console.WriteLine("Roses are " + color);
        Console.WriteLine(pluralNoun + " are blue");
        Console.WriteLine("I Love " + celebrity);
        

        Console.ReadLine();
    }
}
// Mad libs application



// CREATING METHODS
// method is a container or block where we can put code to perform a certain task
// some people will also call these functions interchangeably. 

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        SayHi(); // calling the new method
    }

    static void SayHi() 
    {
        Console.WriteLine("Hello User");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        SayHi("Mike"); 
    }

    static void SayHi(string name) 
    {
        Console.WriteLine("Hello User" + name);
    }
}
// Hello Mike

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        SayHi("Mike"); 
        SayHi("John"); 
        SayHi("Tom"); 
    }

    static void SayHi(string name) 
    {
        Console.WriteLine("Hello User" + name);
    }
}
// Hello Mike
// Hello John
// Hello Tom

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        SayHi("Mike", 33); 
        SayHi("John", 56); 
        SayHi("Tom", 12); 
    }

    static void SayHi(string name, int age) 
    {
        Console.WriteLine("Hello User" + name + " you are" + age);
    }
}

// Hello Mike you are 33
// Hello John you are 56
// Hello Tom you are 12