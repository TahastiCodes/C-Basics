// int test1 = 1234567890; //? from -2147483648 to 2147483647
// short test2 = 30000; //? whole number with a size of 16 bits
// long test3 = 32783462393; //? whole number with a size of 64bits
// float dec = 1.5f; // ? 32 bit, non-whole number, up to 7 digits. Uses the suffix f.
// double dec2 = 1.5000000d; // ? 64 bit, up to 15-16 digits. Uses the optional suffix d.
// decimal dec3 = 8.3333333333m; // ? 128 bit, up to 28-29 digits, more precise than or , but uses more memory. Uses the suffix m.
// bool booly = true; //? true or false value
// char singleLetter = 'a'; // ? A single character ex: 'a' '@' '2' '\n'
// string greeting = "Hello World"; // ? A collection of characters with a size of up to 2 gigs

// bool isLoggedIn = true;
// Console.WriteLine(isLoggedIn);

using System.Runtime.InteropServices;

int number = 3;
string name = "Tahasti";
bool isSleepy = true;
float temp = 70.5f;
double oneThird = 3.333333d;
decimal bankAccount = 30000.00m;
long maxValue = 184467;
Console.WriteLine(oneThird);
Console.WriteLine(maxValue);

string firstName = "Finn";
string lastName = "Mertins";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

string words = "Here's some words!";
int integer = 100;
string wordsPlusNumber = words + integer;
Console.WriteLine(wordsPlusNumber);

string year = "2023";
int yearNumber = int.Parse(year);
Console.WriteLine(yearNumber);

int anotherNumber = Convert.ToInt32(year);

Console.WriteLine(anotherNumber);

