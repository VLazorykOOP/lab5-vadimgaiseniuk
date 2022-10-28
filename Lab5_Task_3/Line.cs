namespace Lab5_Task_3;

public class Line : Function
{
    private double A { get; }
    private double B { get; }
    private double X { get; }

    public Line(double a, double b, double x) => (A, B, X) = (a, b, x);

    public override double CalculateY()
    {
        Console.Write("Line: ");
        
        return A * X + B;
    }
}