string name = Console.ReadLine();

switch (name)

{

    case "Josh":

    Console.WriteLine("Hi Josh");

    break;

    case "Danielle":

    Console.WriteLine("Hi Danielle");

    break;

    case "Adam":

    Console.WriteLine("Hi Adam");

    break;

    default:

    Console.WriteLine("Who are you?");

    break;

}

Console.WriteLine("On a scale of 1-5 how are you feeling today?");

string feelingRating = Console.ReadLine();

switch (feelingRating)

{

    case "5":

    Console.WriteLine("That's great to hear!");

    break;

    case "4":

    Console.WriteLine("Good Stuff");

    break;

    case "3":

    Console.WriteLine("Hope things improve!");

    break;

    case "2":

    Console.WriteLine("Sorry to hear that!");

    break;

    case "1":

    Console.WriteLine("We hope your day gets better.");

    break;

    default:

    Console.WriteLine("Please input a number 1-5");

    break;

}