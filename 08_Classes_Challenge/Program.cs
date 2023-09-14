using ClassesChallenge;
Pets myDog = new Pets();
myDog.Name = "Luciano";
myDog.Type = "Dog";
myDog.Age = 3;
myDog.IsCute = true;
Console.WriteLine(myDog.Name);
Console.WriteLine(myDog.Type);
Console.WriteLine(myDog.Age);
Console.WriteLine(myDog.IsCute);
Console.WriteLine($"My Pet is a {myDog.Type} named {myDog.Name}");
namespace ClassesChallenge
{
    class Pets
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public bool IsCute { get; set; }
    }
}
