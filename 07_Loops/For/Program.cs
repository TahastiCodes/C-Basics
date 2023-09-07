//? for (initializer; condition; iterator)
//? body

//int number = 100;

//for (int i = 0; i < number; i++)
//{
  //  Console.WriteLine(i);
//}

Console.WriteLine("Enter your number that you want to count to?");
int userInput = int.Parse(Console.ReadLine ());
for (int i = 0; i <= userInput; i++)
{
    Console.WriteLine(i);
}