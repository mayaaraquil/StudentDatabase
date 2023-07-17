string[] names = { "Justin Jones", "Zach Buth", "Omar Abdulla", "Ethan Thomas", "Joe Heath", "Forrest Verellen", "Doug Chu", "Maya Araquil", "Shane Chastain", "Timothy Montague", "Maria Ragone" };
string[] homeTowns = { "Columbus", "Grand Rapids", "Dearborn", "Rolla", "Howell", "Traverse City, MI", "PoughKeepsie", "West Bloomfield", "Rochester Hills", "Cilo", "Farmington Hills" };
string[] foods = { "Baja Blast", "Pizza", "Cheese Pizza", "Hot Wings", "Tacos", "Spaghetti", "Sushi", "Sinigang", "Pizza", "Mole", "Lasagna" };

bool search = true;
while (search)
{
    Console.WriteLine($"Enter the student number: 0 - {names.Length -1}");
    int choice = int.Parse( Console.ReadLine());
    Console.WriteLine(names[choice]);

    while (true)
    {
        Console.WriteLine($"Enter the category to display: Hometown or Favorite Food");
        string category = Console.ReadLine().Trim().ToLower();
        if (category == "hometown")
        {
            Console.WriteLine(homeTowns[choice]);
            break;
        }
        else if (category == "favorite food")
        {
            Console.WriteLine(foods[choice]);
            break;
        }
        else
        {
            Console.WriteLine("That's not a valid choice");
            continue;
        }
    }
    while (true)
    {
        Console.WriteLine($"Do you want to search again? y/n");
        string answer = Console.ReadLine().Trim().ToLower();
        if (answer == "n")
        {
            Console.WriteLine($"okay, BYE BYE :)");
            search = false;
            break;
        }
        else if ( answer == "y")
        {
            search = true;
            break;
        }
        else
        {
            Console.WriteLine("Please enter 'y' or 'n'");
        }
    }
  
}