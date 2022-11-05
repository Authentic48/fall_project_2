using fall_project_2.enums;

namespace fall_project_2;

public sealed class Money
{

    private ulong _integer;
    public ulong Integer => _integer;

    private ushort _fraction;
    public ushort Fraction => _fraction;

    private char _sign;
    public Char Sign => _sign;

    public Currency Currency { get; }

    public override string ToString()
    {
        return $"{_integer}.{_fraction}";
    }

    public Money(string money, Currency currency)
    {
        Currency = currency;
        String[] newValue = money.Split('.');
        this._integer = Convert.ToUInt64(newValue[0]);
        this._fraction = Convert.ToUInt16(newValue[1]);
        this._sign = money.StartsWith('-') ? '-' : '+';

    }
}