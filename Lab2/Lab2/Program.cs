namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Read all lines from employees file
        string[] employeeLines = File.ReadAllLines("../../../res/employees.txt");

        List<Employee> employees = GetEmployees(employeeLines);
        List<Wages> wagesList = [];
        List<Salaried> salariedList = [];
        List<PartTime> partTimeList = [];

        double sum = 0;

        foreach (Employee employee in employees)
        {
            switch (employee)
            {
               case Wages wages:
                   sum += wages.GetPay();
                   wagesList.Add(wages);
                   break;
               case Salaried salaried:
                   sum += salaried.GetPay();
                   salariedList.Add(salaried);
                   break;
               case PartTime partTime:
                   sum += partTime.GetPay();
                   partTimeList.Add(partTime);
                   break;
            }
        }

        // Calculate Highest/Lowest
        Wages highestPaidWages = GetHighestPaidWages(wagesList);
        Salaried lowestPaidSalaried = GetLowestPaidSalaried(salariedList);
       
        // Calculate average
        double average = Math.Round(sum / employees.Count, 2);
        
        // Calculate percentages
        double salariedPercent = Math.Round((double)salariedList.Count/employees.Count*100, 1);
        double wagesPercent = Math.Round((double)wagesList.Count/employees.Count*100, 1);
        double partTimePercent = Math.Round((double)partTimeList.Count/employees.Count*100, 1);

        // Print highest paid Wages
        Console.WriteLine("\nThe highest paid Wages employee is:");
        Console.WriteLine(highestPaidWages);

        // Print lowest paid Salaried
        Console.WriteLine("\nThe lowest paid Salaried employee is:");
        Console.WriteLine(lowestPaidSalaried);

        // Print average
        Console.WriteLine($"\nThe average pay is {average}");

        // Print percentages
        Console.WriteLine($"\nThe percentage of Employees who are Salaried is: {salariedPercent}%");
        Console.WriteLine($"The percentage of Employees who are Wages is: {wagesPercent}%");
        Console.WriteLine($"The percentage of Employees who are Part Time is: {partTimePercent}%");
    }

    static List<Employee> GetEmployees(string[] employeeLines)
    {
        List<Employee> employees = [];
        
        // Process each line, adding new employees to the List of employees
        foreach (string employeeLine in employeeLines)
        {
            // Split line by separator
            string[] split = employeeLine.Split(":");
            int idFirstDigit = int.Parse(split[0][0].ToString());

            // Read all Employees attributes
            string id = split[0];
            string name = split[1];
            string address = split[2];
            string phone = split[3];
            long sin = long.Parse(split[4]);
            string dob = split[5];
            string dept = split[6];
            
            Employee newEmployee;
            switch (idFirstDigit)
            {
                case >= 0 and <= 4:
                    // Create Salaried
                    double salary = double.Parse(split[7]);
                    newEmployee = new Salaried(id, name, address, phone, sin, dob, dept, salary);
                    break;
                case <= 7:
                    // Create Wages
                    double wagesRate = double.Parse(split[7]); // For some reason this is the same scope as the below case.
                    double wagesHours = double.Parse(split[8]); 
                    newEmployee = new Wages(id, name, address, phone, sin, dob, dept, wagesRate, wagesHours);
                    break;
                case <= 9:
                    // Create PT
                    double ptRate = double.Parse(split[7]);
                    double ptHours = double.Parse(split[8]);
                    newEmployee = new PartTime(id, name, address, phone, sin, dob, dept, ptRate, ptHours);
                    break;
                default:
                    // This should not be called if the .txt file is the proper format.
                    newEmployee = new Employee();
                    break;
            }
            
            employees.Add(newEmployee);
        }

        return employees;
    }

    static Wages GetHighestPaidWages(List<Wages> wagesList)
    {
        Wages highestPaid = wagesList[0];

        foreach (Wages wages in wagesList)
        {
            if (wages.GetPay() > highestPaid.GetPay())
            {
                highestPaid = wages;
            }
        }
        
        return highestPaid;
    }

    static Salaried GetLowestPaidSalaried(List<Salaried> salariedList)
    {
        Salaried lowestPaid = salariedList[0];

        foreach (Salaried salaried in salariedList)
        {
            if (salaried.GetPay() < lowestPaid.GetPay())
            {
                lowestPaid = salaried;
            }
        }

        return lowestPaid;
    }
}