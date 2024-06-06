namespace PersonProject;

public class Person
{
    
    public int personId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string favoriteColour { get; set; }
    public int age { get; set; }
    public bool isWorking { get; set; }

    // Method to display person's information
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name= {firstName} {lastName}");
        Console.WriteLine($"{personId}: {firstName} {lastName}'s favorite color is {favoriteColour}");
    }

    // Method to change the person's favorite color
    public void ChangeFavoriteColour(string color)
    {
        favoriteColour = color;
    }

    // Method to get the person's age after 10 years
    public int GetAgeInTenYears()
    {
        return age + 10;
    }

    // Override ToString method to display all person object information as a list
    public override string ToString()
    {
        return $"Person ID: {personId}\n" +
               $"Name: {firstName} {lastName}\n" +
               $"Favorite Colour: {favoriteColour}\n" +
               $"Age: {age}\n" +
               $"Is Working: {isWorking}\n";
    }
}