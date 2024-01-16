namespace Lab1;

public class Relation
{
    public RelationshipType RelationshipType;

    public Relation(RelationshipType relationshipType)
    {
        RelationshipType = relationshipType;
    }

    public void ShowRelationship(Person p1, Person p2)
    {
        Console.WriteLine($"The relation between {p1.firstName} and {p2.firstName} is {RelationshipType}hood");
    }
}

public enum RelationshipType
{
    Sister, Brother, Mother, Father
}