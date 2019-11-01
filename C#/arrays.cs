// variables can only store a single value. Arrays allows us to hold multiple values inside a single container. It's a collection of variables if you will

class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};

        Console.WriteLine( luckyNumbers[0] );
    }
}
// 4

// updating an array..

class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};

        luckyNumbers[1] = 900;

        Console.WriteLine( luckyNumbers[1] );
    }
}
// 900

class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
        string[] friends = new string[5]; //-- inside of these square brackets, you need to put in a number. This number is going to tell C# how many elements we want this array to hold, how big we want the array. 

        // then we can populate this array with values
        friends[0] = "Jim";
        friends[1] = "Kelly";
        // etc

        Console.WriteLine( luckyNumbers[1] );
    }
}
// 900


// all of the elements in an array have to be of the same type