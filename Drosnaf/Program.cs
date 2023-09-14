Console.WriteLine("Please add all of the following points to the beginning total of 5000");
string start = Console.WriteLine("5000");

Console.WriteLine("Bird points");
string num1 = Console.ReadLine();

Console.WriteLine("Enter Evening Grosbeaks.");
string num2 = Console.ReadLine();

Console.WriteLine("Enter number of Vulnerable Bird Hunters pts.");
string num3 = Console.ReadLine();

Console.WriteLine("Greater Prairie Chickens?");
string num4 = Console.ReadLine();

Console.WriteLine("Iceland Gull?");
string num5 = Console.ReadLine();

Console.WriteLine("Crested Ibis?");
string num6 = Console.ReadLine();

Console.WriteLine("Great Kiskudee?");
string num7 = Console.ReadLine();

Console.WriteLine("Red Cross Bill?");
string num8 = Console.ReadLine();

Console.WriteLine("Red Necked Phalarope?");
string num9 = Console.ReadLine();

Console.WriteLine("Orange Bellied Parrot?");
string num10 = Console.ReadLine();

int total = int.Parse(start) + int.Parse(num1) + int.Parse(num2) + int.Parse(num3) + int.Parse(num4) + int.Parse(num5) + int.Parse(num6) + int.Parse(num7) + int.Parse(num8) + int.Parse(num9) + int.Parse(num10);

Console.WriteLine($"Total points scored is {total}");