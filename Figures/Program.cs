namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our \"Shapes\" Program!");
            Console.WriteLine();

            string myChoice = "";

            do
            {
                Console.WriteLine("Please, select your shape:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Tringle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. Circle");
                myChoice = Console.ReadLine();
                Shape myShape = null;

                switch (myChoice)
                {
                    case "1":
                        myShape = new Rectangle();
                        Console.Write("Please, enter the width of the rectangle: ");
                        myShape.Width = int.Parse(Console.ReadLine());
                        Console.Write("Please, enter the height of the rectangle: ");
                        myShape.Height = int.Parse(Console.ReadLine());
                        break;
                    case "2":
                        myShape = new Triangle();
                        Console.Write("Please, enter base of the triangle: ");
                        myShape.Base = int.Parse(Console.ReadLine());
                        Console.Write("Please, entet the height of the triangle: ");
                        myShape.Height = int.Parse(Console.ReadLine());
                        Console.Write("Please, enter the length of side 1: ");
                        myShape.Side1 = int.Parse(Console.ReadLine());
                        Console.Write("Please, enter the length of side 2: ");
                        myShape.Side2 = int.Parse(Console.ReadLine());
                        Console.Write("Please, enter the length of side 3: ");
                        myShape.Side3 = int.Parse(Console.ReadLine());
                        break;
                    case "3":
                        myShape = new Square();
                        Console.Write("Please, enter the side length of the square: ");
                        myShape.Side = int.Parse(Console.ReadLine());
                        break;
                    case "4":
                        myShape = new Circle();
                        Console.Write("Please, enter the radius of the circle: ");
                        myShape.Radius = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please, enter 1, 2, 3 or 4.");
                        return;
                }

                Console.WriteLine($"The area is: {Math.Round(myShape.GetArea(), 2)}.");
                Console.WriteLine($"The perimeter is: {Math.Round(myShape.GetPerimeter(), 2)}.");
                Console.WriteLine("Would you like to continue?: (Yes/No)");
                myChoice = Console.ReadLine();

            }
            while (myChoice != "No");

        }
    }
}