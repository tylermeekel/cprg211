namespace Lab2;

public class Salaried : Employee
{
    public double Salary { get; set; }

    public Salaried() : base()
    {
        Salary = 0.0;
    }

    public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) : 
        base(id, name, address, phone, sin, dob, dept)
    {
        Salary = salary;
    }

    public double GetPay()
    {
        return Salary;
    }

    public override string ToString()
    {
        return $"ID: {Id}\n" +
               $"Name: {Name}\n" +
               $"Address: {Address}\n" +
               $"Phone: {Phone}\n" +
               $"SIN: {Sin}\n" +
               $"Date of Birth: {Dob}\n" +
               $"Department: {Dept}\n" +
               $"Salary: {Salary}";
    }
}