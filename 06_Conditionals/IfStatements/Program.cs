// ! if (true/false value)
//?{
//? Body of code to execute if value in parenthesis is true
//? }

bool isRaining = false;
bool isGoingOutside = true;

if (isRaining)
{
    Console.WriteLine("Bring umbrella!");
}

if (isRaining && isGoingOutside)
{
    Console.WriteLine("Better bring an unbrella!");
}

if (!isRaining || !isGoingOutside)
{
    Console.WriteLine("Don't need unbrella.");
}

if (isRaining ^ isGoingOutside)
{
    Console.WriteLine("I will only go out if it's not raining.");
}

if (isRaining)

{

    Console.WriteLine("Bring an umbrella!");

}

 

if (isRaining && isGoingOutside)

{

    Console.WriteLine("Better bring an umbrella!");

}

 

if (!isRaining || !isGoingOutside)

{

    Console.WriteLine("I do not need an umbrella.");

}

 

if (isRaining ^ isGoingOutside)

{

    Console.WriteLine("I will only go outside if it is not raining.");

}

if (!isRaining)
{
    Console.WriteLine("I will go cut the grass.");
}
else 
{
    Console.WriteLine("I won't cut the grass");
}

if (isGoingOutside)
{
    Console.WriteLine("Make sure to dress for the weather!");
}
else
{
    Console.WriteLine("I'll stay in in my PJ's.");
}

Console.WriteLine("On a scale of 1-5, how are you feeling today?");

string feelingRating = Console.ReadLine();

if (feelingRating == "5")

{

    Console.WriteLine("That's great to hear");

}

else if (feelingRating == "4")

{

    Console.WriteLine("Good Stuff!");

}

else if (feelingRating == "3")

{

    Console.WriteLine("Hope things improve!");

}

else if (feelingRating == "2")

{

    Console.WriteLine("Sorry to hear that!");

}

else if (feelingRating == "1")

{

    Console.WriteLine("We hope your day gets better!");

}

else

{

    Console.WriteLine("Sorry, we don't understand. Please input a number from 1-5.");

}