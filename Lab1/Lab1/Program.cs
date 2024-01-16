namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // a. Create four objects using the data
        Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person gina = new Person(2, "Gina", "James", "Green", 18, false);
        Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);
        
        // b. Display Gina’s information as a sentence that shows her id, first name, last name and her favorite colour. 
        gina.DisplayPersonInfo();
        
        // c. Display all of Mike's information as a list
        Console.WriteLine(mike);
        
        // d. Change Ian's favorite colour to white then print his info as a sentence.
        ian.ChangeFavoriteColour();
        ian.DisplayPersonInfo();
        
        // e. Display Mary's age after 10 years
        Console.WriteLine($"Mary's age after 10 years will be {mary.GetAgeInTenYears()}");
        
        // f. Create two relation objects to show that Gina and Mary are sisters and that Ian and Mike are brothers
        // Then, display both relationships.
        Relation brothers = new Relation(RelationshipType.Brother);
        Relation sisters = new Relation(RelationshipType.Sister);
        
        brothers.ShowRelationship(ian, mike);
        sisters.ShowRelationship(gina, mary);

        // g. Add all people to a list
        List<Person> personList = new List<Person>();
        personList.Add(ian);
        personList.Add(gina);
        personList.Add(mike);
        personList.Add(mary);
        
        // Display things
        int ageSum = 0;
        Person youngest = personList[0];
        Person oldest = personList[0];
        
        foreach (Person person in personList)
        {
            ageSum += person.age;
            
            // Check if they are the youngest
            if (person.age < youngest.age)
            {
                youngest = person;
            }
            
            // Check if they are the oldest
            if (person.age > oldest.age)
            {
                oldest = person;
            }

            // Check if their name starts with M
            if (person.firstName[0] == 'M')
            {
                // Print their name if it does
                Console.WriteLine($"{person.firstName}'s name starts with M");
            }
        }
        
        // Print the average age, use type casting to print the correct number\
        Console.WriteLine($"The average age of these people is {(double)ageSum/(double)personList.Count}");
        
        // Print the youngest
        Console.WriteLine($"The youngest person in this list is {youngest.firstName}");
        
        // Print the oldest
        Console.WriteLine($"The oldest person in this list is {oldest.firstName}");
    }
}