
System.Console.Write("Please give me the length of a rectangle");
string length = Console.ReadLine();

System.Console.Write("Please give me the width of a rectangle");
string width = Console.ReadLine();

Rectangle rectangle3 = new Rectangle(length, width);
System.Console.WriteLine($"I want to calculate a rectangle that is {rectangle3.GetWidth()} X {rectangle3.GetLength()}");
System.Console.WriteLine(rectangle3.Area());

Rectangle rectangle1 = new Rectangle();

System.Console.WriteLine($"I want to calculate a rectangle that is {rectangle1.GetWidth()} X {rectangle1.GetLength()}");
System.Console.WriteLine(rectangle1.Area());

Rectangle rectangle2 = new Rectangle(10, 10);

System.Console.WriteLine($"I want to calculate a rectangle that is {rectangle2.GetWidth()} X {rectangle2.GetLength()}");
System.Console.WriteLine(rectangle2.Area());




Random rand = new Random();

string name2 = "Mathew";

System.Console.WriteLine(rand.Next(10));
Car car = new Car();
System.Console.WriteLine(car.IsMyCarOn());

car.Power("key");
System.Console.WriteLine(car.IsMyCarOn());
car.Power("secret key is");
System.Console.WriteLine(car.IsMyCarOn());


//System.Console.WriteLine(Car.RoadCond("It is a beautiful day!".ToUpper()));

//string name = "Mathew";
//String name = new String("Mathew");

