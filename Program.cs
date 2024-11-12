using static Assignment_2_2.Circle;

namespace Assignment_2_2
{
    //Create a base class called "Shape" and add properties for ID, Name, and Color and create a method to calculate the area of the shape. 
    public abstract class Shape // This is the parent abstract class. Abstract classes cannot be used to create objects. 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public abstract double CalculateArea(); // This is an Abstract Method that does not contain a body.
    }

    public class Circle : Shape // This is a child class called "Circle" that inherits from the Shape class using the : symbol. 
    {
        public double Radius 
        { get; set; }

        public override double CalculateArea() // We use the CalculateArea method created in the parent class and assign it's function here to claculate the area of a circle. 
        {
            return Math.PI * Math.Pow(Radius, 2); //Area of a circle is pie * radius squared

        }

        public class Square : Shape // This is a child class called "Square" that inherits from the Shape class using the : symbol. 
        {
            public double Side
            { get; set; }

            public override double CalculateArea() 
            {
                return Side * Side; //Area of a square is base * height
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   //Creating the Main Menu i
            Console.WriteLine("Choose a shape to calculate area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.Write("Enter your choice (1 or 2): ");

            string choice = Console.ReadLine();
            Shape shape = null;

            // Determine which shape the user selected
            switch (choice)
            {
                case "1":
                    // Create a Circle object
                    shape = new Circle { Id = 1, Name = "Circle", Color = "Red" };
                    Console.Write("Enter the radius of the circle: ");
                    double radius;
                    while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                    {
                        Console.Write("Invalid input! Please enter a positive number for radius: ");
                    }
                    ((Circle)shape).Radius = radius;
                    break;

                case "2":
                    // Create a Square object
                    shape = new Square { Id = 2, Name = "Square", Color = "Blue" };
                    Console.Write("Enter the side length of the square: ");
                    double side;
                    while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
                    {
                        Console.Write("Invalid input! Please enter a positive number for side length: ");
                    }
                    ((Square)shape).Side = side;
                    break;

                default:
                    Console.WriteLine("Invalid choice! Exiting program.");
                    return;
            }

            // Display the calculated area
            Console.WriteLine($"\nShape Details:");
            Console.WriteLine($"ID: {shape.Id}");
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Color: {shape.Color}");
            Console.WriteLine($"Area: {shape.CalculateArea():F2}");

            Console.ReadLine(); // Pause to let user see the output
        }
    }
}
 
