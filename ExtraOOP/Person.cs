namespace ExtraOOP;

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Company
{
    private Person[] personal;
    public Company(Person[] people) => personal = people;

    public Person this[int index]
    {
        get
        {
            if (index >= 0 && index < personal.Length)
                return personal[index];
            else
                throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < personal.Length)
                personal[index] = value;
        }
    }

    public Person this[string name]
    {
        get
        {
            foreach (var person in personal)
            {
                if (person.Name == name) return person;
            }
            throw new Exception("Unknown name");
        }
    }
}