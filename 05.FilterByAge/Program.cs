/*
5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
older
20
name age

5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
younger 
20
name

5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
younger 
50
age

 */

List<Person> people = ReadPeople();

string condition = Console.ReadLine().Trim();
int ageThreshold = int.Parse(Console.ReadLine().Trim());

Func<Person, bool> filter = CreateFilter(condition, ageThreshold);

string format = Console.ReadLine();

Action<Person> printer = CreatePrinter(format);

PrintFilteredPeople(people, filter, printer);



List<Person> ReadPeople()
{
    List<Person> people = new List<Person>();

    int count = int.Parse(Console.ReadLine());

    for (int i = 0; i < count; i++)
    {
        string[] personTokkens = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries);

        Person person = new Person();

        person.Name = personTokkens[0];
        person.Age = int.Parse(personTokkens[1]);

        people.Add(person);
    }

    return people;
}

Func<Person, bool> CreateFilter(string condition, int ageThreshold)
{
    switch (condition)
    {
        case "younger": return p => p.Age < ageThreshold;
        case "older": return p => p.Age >= ageThreshold;
        default: return null;
            
    }
    
}

Action<Person> CreatePrinter(string format)
{
    switch (format)
    {
        case "name age": return p => Console.WriteLine($"{p.Name} - {p.Age}");
        case "age": return p => Console.WriteLine($"{p.Age}");
        case "name": return p => Console.WriteLine($"{p.Name}");

        default: return null;
            

    }
}

void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
{
    foreach (Person person in people)
    {
        if (filter(person))
        {
            printer(person);
        }
    }
}
public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}