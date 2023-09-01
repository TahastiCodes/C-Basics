//? Negation operator
bool isTrue = !false;
bool isFalse = !true;
Console.WriteLine(isFalse);

//? AND operator
bool trueAndExample = true && true;
bool falseAndExample = true && false;
Console.WriteLine(falseAndExample);
Console.WriteLine(trueAndExample);

//? OR operator
bool trueOrExample = true || false;
bool falseOrExample = false || false;
Console.WriteLine(trueOrExample);

//? XOR (Exclusive Or) operator
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;
Console.WriteLine(falseExclusiveOr);

//? Equals & Not Equals
bool equality = 17 == 9;
bool inequality = 17 != 9;

//? Less Than
bool isLessThan = 5 < 5;
bool isLessThanOrEqual = 5 <= 5;

//? Greater than
bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqual = 10 >= 10;