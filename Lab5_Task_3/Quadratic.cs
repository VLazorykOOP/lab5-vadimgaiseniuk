namespace Lab5_Task_3;

public class Quadratic : Function
{
    private double A { get; }
    private double B { get; }
    private double C { get; }
    private double X { get; }

    public Quadratic(double a, double b, double c, double x) => (A, B, C, X) = (a, b, c, x);
    
    public override double CalculateY()
    {
        Console.Write("Quadratic: ");
        
        return Math.Pow(A * X, 2) + B * X + C;
    }
}