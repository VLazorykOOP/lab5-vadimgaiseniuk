namespace Lab5_Task_3;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the X value: ");
        var x = Convert.ToDouble(Console.ReadLine());
        
        List<Function> functions = new List<Function>();
        
        functions.Add(new Line(-3, 5, x));
        functions.Add(new Quadratic(4, -3, 2, x));
        functions.Add(new Hyperbola(5, x));

        foreach (var function in functions)
        {
            Console.WriteLine(function.CalculateY());
        }
    }
}