string first = "The colors I like are";
string second = "Grey and Crimson";

//? We're concatenating a new string with only a space here. Notice we can combine it with the variables from above.

string concatResult = first + " " + second;
Console.WriteLine(concatResult);

string interpolationResult = $"{first} {second}! I also like pink!";
Console.WriteLine(interpolationResult);

string firstName = "Tahasti";
string lastName = "Hopper";
string compositeResult = string.Format("My name is {0} {1}", firstName, lastName);
Console.WriteLine(compositeResult);