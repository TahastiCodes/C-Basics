//? boolean expression ? expression if true : expression if false; basically if else stmnts

Console.Write("Enter your age: ");
string response = Console.ReadLine();
int age = int.Parse(response);

string output = age >= 18 ? "You can vote!" : "Too young to vote.";

Console.WriteLine(output);

if (age >= 18)
{
    output = "You can vote!":
}
else
{
    output = "You're too young to vote.";
}

