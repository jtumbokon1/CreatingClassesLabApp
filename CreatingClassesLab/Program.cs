using CreatingClassesLab;

class Program
{
    public static void Main()
    {
        Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
        Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

        Console.WriteLine(person2.DisplayPersonInfo()); // display gina's information

        Console.WriteLine(person3.ToString()); // display mike's information as a list

        person1.ChangeFavoriteColour();
        Console.WriteLine(person1.DisplayPersonInfo()); // change ian's favorite colour to white then display info

        Console.WriteLine($"{person4.FirstName} {person4.LastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}"); //display mary's age in 10 years

        Relation sisters = new Relation(RelationshipType.Sister);
        Relation brothers = new Relation(RelationshipType.Brother);

        Console.WriteLine(sisters.ShowRelationship(person2, person4)); // display gina and mary's relationship as sisters
        Console.WriteLine(brothers.ShowRelationship(person1, person3)); // display ian and mike's relationship as brothers

        List<Person> people = new List<Person>();
        people.Add(person1);
        people.Add(person2);
        people.Add(person3);
        people.Add(person4);

        double averageAge = people.Average(p => p.Age);
        Console.WriteLine($"Average age is: {averageAge}"); // get average age then display it

        string youngestPerson = people.OrderBy(p => p.Age).First().FirstName;
        Console.WriteLine($"The youngest person is: {youngestPerson}"); // order list by ascending age (starting w/ youngest) then display first person's first name

        string oldestPerson = people.OrderByDescending(p => p.Age).First().FirstName;
        Console.WriteLine($"The oldest person is: {oldestPerson}"); // order list by descending age (starting w/ oldest) then display first person's first name

        foreach (Person p in people) // display all people with a first name that contains the letter "M"
        {
            if (p.FirstName.Contains("M"))
            {
                Console.WriteLine(p.ToString());
            }
        }

        foreach (Person p in people) // display all people with a favorite colour of "Blue"
        {
            if (p.FavoriteColour == "Blue")
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}

