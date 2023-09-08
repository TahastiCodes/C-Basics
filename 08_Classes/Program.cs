using Classes;

Donut doug = new Donut("Jelly Filled", 3);
//doug.donutType = "Jelly Filled";
//Console.WriteLine(doug.donutType);
//Console.WriteLine(doug.price);
doug.SetDonutType("Glazed");
Console.WriteLine(doug.GetDonutType());
doug.Filling = "Strawberry Jam";
Console.WriteLine(doug.Filling);
doug.Topping = "Caramel";
Console.WriteLine(doug.Topping);
doug.isSpecial = false;
Console.WriteLine(doug.isSpecial);
namespace Classes
{
    class Donut
    {     
        public string donutType;
        private int price;
        public Donut (string type, int dollars)
        {
            donutType = type;
            price = dollars;
        }
        public string Filling { get; set; }
        public string GetDonutType()
        {
            return donutType;
        }
        public string Topping { get; set; }
        public bool isSpecial { get; set; }
        public void SetDonutType(string type)
        {
            donutType = type;
        }
    }
}


//? accessModifer returnType MethodName(parameterType parameterName)
//? {
//? statements that will run    
//?}

