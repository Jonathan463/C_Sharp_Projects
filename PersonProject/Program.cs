namespace PersonProject;

class Program
{
    // Running the program in the main method
    static void Main(string[] args)
    {
        // Create Person objects
        Person person1 = new Person
        {
            personId = 1,
            firstName = "Jane",
            lastName = "Ola",
            favoriteColour = "blue",
            age = 25,
            isWorking = true
        };

        Person person2 = new Person
        {
            personId = 2,
            firstName = "Saheed",
            lastName = "Ola",
            favoriteColour = "red",
            age = 22,
            isWorking = false
        };
        
        Person person3 = new Person
        {
            personId = 3,
            firstName = "Chidubem",
            lastName = "Godson",
            favoriteColour = "green",
            age = 30,
            isWorking = true
        };

        // Display person information
        person1.DisplayPersonInfo();
        person2.DisplayPersonInfo();

        // Change favorite color of person1
        Console.WriteLine("Enter Color");
        string color = Console.ReadLine();
        person1.ChangeFavoriteColour(color);
        Console.WriteLine($"After changing favorite color, {person1.firstName} {person1.lastName}'s favorite color is now {person1.favoriteColour}");

        // Get age in 10 years
        Console.WriteLine($"{person1.firstName} {person1.lastName} will be {person1.GetAgeInTenYears()} years old in 10 years.");

        // Display all information using ToString
        Console.WriteLine(person1.ToString());
        Console.WriteLine(person2.ToString());

        // Create Relation object
        Relation relation = new Relation();

        // Show relationship
        relation.ShowRelationShip(person1, person2);
        relation.ShowRelationShip(person1, person3);
    }
}