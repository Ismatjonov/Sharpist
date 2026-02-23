namespace ExtraOOP;
public class Money
{
    public int Value { get; set; }

    public static Money operator +(Money money, int n)
    {
        return new Money { Value = money.Value + n };
    }

    public static Money operator +(Money m1, Money m2)
    {
        return new Money { Value = m1.Value + m2.Value };
    }
}