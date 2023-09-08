using Classes;
using ClassesChallenge;

pets myDog = new Pets();
//doug.donutType = "Jelly Filled";
//Console.WriteLine(doug.donutType);
//Console.WriteLine(doug.price);
petDog.Name = "Lucci";
petDog.Type = "Dog";
petDog.Age = 3;
petDog.isCute = true;

namespace ClassesChallenge
{
    class petDog
    {     
        private string dogType;
        private int price;
        public petDog (string type, int dollars)
        {
            dogType = type;
            price = dollars;
        }
        private string petDog.age { get; set; }
        public bool isCute { get; set; }
        
    }
}


//? accessModifer returnType MethodName(parameterType parameterName)
//? {
//? statements that will run    
//?}

