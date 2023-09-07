string[] instructors = new string[] {"Danielle", "Marty", "Andrew", "Terry"};

foreach (string name in instructors)
{
  Console.WriteLine(name);
}

//? Declare a new array of integers, iterate over this array with a foreach loop, write to the console whether or not the numbers are negative or positive.

int[] numbers = new int[] {1, 4, 7, 10, 14, 18, 0, -7, -3};

foreach (int number in numbers)
{
    if (number > 0)
    {
        Console.WriteLine($"{number} is positive");
    }
    else if (number < 0)
    {
        Console.WriteLine($"{number} is negative");
    }
    else
    {
        Console.WriteLine($"{number} is neutral");
    }
}

//Create a for loop to print the numbers 1-100. If the number is divisible by 3, print Fizz instead of the number. If it's divisible by 5, print Buzz , instead of the number. If it's divisible by both 3 and 5, print Fizz Buzz otherwise print the number.

//for (int i = 500; i <= 525; i++)
//{
  //  Console.WriteLine(i);
//}

//for (int i = 0; i <= 100; i+= 5)
//{
  //  Console.WriteLine(i);
//}

for (int i = 0; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Console. WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
} 
