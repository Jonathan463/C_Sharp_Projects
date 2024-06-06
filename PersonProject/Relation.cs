namespace PersonProject;

public class Relation
{
    // Enum for relationship type
    public enum RelationshipType
    {
        Sister,
        Brother,
        Mother,
        Father
    }

    // Method to show relationship between two persons
    public void ShowRelationShip(Person person1, Person person2)
    {
        if (person1.lastName == person2.lastName)
        {
            Console.WriteLine($"{person1.firstName} {person1.lastName} and {person2.firstName} {person2.lastName} are related.");
        }
        else
        {
            Console.WriteLine($"{person1.firstName} {person1.lastName} and {person2.firstName} {person2.lastName} are not related.");
        }
    }
}