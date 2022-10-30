namespace Lab5_Task_2;

public static class Program
{
    public static void Main()
    {
        Person person = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 0);
        Person worker = new Worker("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.6, "Microsoft");
        Person engineer = new Engineer("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 1.4, "Bachelor");
        Person employee = new Employee();
        
        person.Show();
        Console.WriteLine("---------------------------------------------");
        worker.Show();
        Console.WriteLine("---------------------------------------------");
        engineer.Show();
        Console.WriteLine("---------------------------------------------");
        employee.Show();

    }
}