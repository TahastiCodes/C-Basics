using Classes;

Donut doug = new Donut("Jelly Filled", 3);
//doug.donutType = "Jelly Filled";
//Console.WriteLine(doug.donutType);
//Console.WriteLine(doug.price);
doug.SetDonutType("Glazed");
Console.WriteLine(doug.GetDonutType());

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
        public string GetDonutType()
        {
            return donutType;
        }
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

