namespace Lab5_Task_3;

public class Hyperbola : Function
{
    private double K { get; }
    private double X { get; }

    public Hyperbola(double k, double x) => (K, X) = (k, x);
    
    public override double CalculateY()
    {
        Console.Write("Hyperbola: ");
        
        return K / X;
    }
}