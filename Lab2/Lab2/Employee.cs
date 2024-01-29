namespace Lab2;

public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public long Sin { get; set; }
    public string Dob { get; set; }
    public string Dept { get; set; }

    public Employee()
    {
        Id = "ABC123";
        Name = "John Smith";
        Address = "123 Street St";
        Phone = "123-456-7890";
    }

    public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
    {
        Id = id;
        Name = name;
        Address = address;
        Phone = phone;
        Sin = sin;
        Dob = dob;
        Dept = dept;
    }

    public override string ToString()
    {
        return $"ID: {Id}\n" +
               $"Name: {Name}\n" +
               $"Address: {Address}\n" +
               $"Phone: {Phone}\n" +
               $"SIN: {Sin}\n" +
               $"Date of Birth: {Dob}\n" +
               $"Department: {Dept}";
    }
}