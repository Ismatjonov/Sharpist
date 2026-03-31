namespace ExtraOOP;

public class Soccer
{
    public string Name { get; set; }
    public int Number { get; set; }

    public Soccer(string name, int number)
    {
        Name = name;
        Number = number;
    }
}

public class Team
{
    public Soccer[] Soccers;

    public Team(Soccer[] soccers) => Soccers = soccers;
    
    public Soccer this[int index]
    {
        get
        {
            if (index >= 0 && index < Soccers.Length)
                return Soccers[index];
            throw new IndexOutOfRangeException();
        }
        set
        {
            Soccers[index] = value;
        }
    }
}