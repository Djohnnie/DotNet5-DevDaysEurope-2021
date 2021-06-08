using System.Collections.Generic;

Dictionary<string, string> dictionary1 = new Dictionary<string, string>();
var dictionary2 = new Dictionary<string, string>();
Dictionary<string, string> dictionary3 = new();

Dictionary<string, List<Person>> dictionary4 = new()
{
    { "A", new() { new("1") { Age = 1 }, new("2") { Age = 2 } } },
    { "B", new() { new("3") { Age = 3 }, new("4") { Age = 4 } } },
    { "C", new() { new("5") { Age = 5 }, new("6") { Age = 6 } } }
};

DoSomething(new());

void DoSomething(List<Person> p)
{

}

public class Person
{
    public string Name { get; set; }
    public byte Age { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}