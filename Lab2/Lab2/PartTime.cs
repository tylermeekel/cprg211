namespace Lab2;

public class PartTime : Employee
{
    public double Rate { get; set; }
    public double Hours { get; set; }

    public PartTime() : base()
    {
        Rate = 0.0;
        Hours = 0.0;
    }

    public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept,
        double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
    {
        this.Rate = rate;
        this.Hours = hours;
    }

    // Pay is Rate*Hours, without overtime
    public double GetPay()
    {
        return Math.Round(Rate * Hours, 2);
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
               $"Pay Rate: {Rate}\n" +
               $"Hours Worked: {Hours}";
    }
}