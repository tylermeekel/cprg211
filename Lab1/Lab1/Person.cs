namespace Lab1;

public class Person
{
    public int personId;
    public string firstName;
    public string lastName;
    public string favoriteColour;
    public int age;
    public bool isWorking;

    public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
    {
        this.personId = personId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.favoriteColour = favoriteColour;
        this.age = age;
        this.isWorking = isWorking;
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"{personId}: {firstName} {lastName}'s favorite colour is {favoriteColour}.");
    }

    public void ChangeFavoriteColour()
    {
        favoriteColour = "white";
    }

    public int GetAgeInTenYears()
    {
        return age + 10;
    }

    public override string ToString()
    {
        return $"First Name: {firstName}\n" +
               $"Last Name: {lastName}\n" +
               $"ID: {personId}\n" +
               $"Age: {age}\n" +
               $"Favorite Colour: {favoriteColour}\n" +
               $"Is Working? {isWorking}";
    }
}