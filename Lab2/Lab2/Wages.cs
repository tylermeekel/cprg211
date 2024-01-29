namespace Lab2;

public class Wages : Employee
{
    public double Rate { get; set; }
    public double Hours { get; set; }

    public Wages() : base()
    {
        Rate = 0.0;
        Hours = 0.0;
    }

    public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id,
        name, address, phone, sin, dob, dept)
    {
        Rate = rate;
        Hours = hours;
    }

    public double GetPay()
    {
        // Check if worked overtime
        if (Hours > 40)
        {
            const double OVERTIMEBONUS = 1.5;
            double extraPay = (40 * Rate) + ((Hours - 40) * OVERTIMEBONUS * Rate);
            return Math.Round(extraPay, 2);
        }

        return Math.Round(Hours * Rate, 2);
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