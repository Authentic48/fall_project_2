using fall_project_2.enums;

namespace fall_project_2;

// TODO Iheritance  IEquatable<Money> and IComparable<Money>
public class Money //: IEquatable<Money>, IComparable<Money>
{
    private readonly Random _random = new Random();

    private readonly Currency _currencies;

    private ulong _integer;
    private ushort _fraction;

    private char _sign;

    private string _currency;

    public ulong GetInteger()
    {

        return this._integer; // AM1
    }

    public char GetSign()
    {
        return this._sign; // AM2
    }
    public ushort GetFraction()
    {
        return this._fraction; // AM3
    }

    public void AddToFraction()
    {
        this._integer += (ushort)(this._fraction / 100);
        this._fraction = (ushort)(this._fraction % 100);
    }

    public void DisplayToConsole()
    {
        Console.WriteLine($"{_integer}.{_fraction}"); // MD
    }
    public void SetInteger(ulong value)
    {
        _integer = value; // MS1
    }
    public void SetFraction(ushort value)
    {
        _fraction = value; // MS2
    }

    public void SetSign(char sign) // MS3
    {
        this._sign = sign;
    }

    public Money() //  C1
    {
        this._integer = (ulong)_random.Next(1, 112) - 4;
        this._fraction = (ushort)(_random.Next(1, 156) * _random.Next(3, 7));
        // this.currency = currencies[random.Next(currencies.Count)];
    }

    public Money(ushort fraction, ulong integer, string currency, char sign) // C2
    {
        this._fraction = fraction;
        this._integer = integer;
        this._currency = currency;
        this._sign = sign;
    }
    public Money(Money money) // C3
    {
        this._integer = money._integer;
        this._fraction = money._fraction;
        this._currency = money._currency;
        this._sign = money._sign;
    }

    public Money(string money) // C4
    {
        String[] newValue = money.Split('.');
        this._integer = Convert.ToUInt64(newValue[0]);
        this._fraction = Convert.ToUInt16(newValue[1]);
        this._sign = GetSignOfNumber(money);

    }

    public char GetSignOfNumber(string number)
    {
        if (number[0] == '-')
        {
            return '-';
        }

        return '+';
    }

    public void Addition(ulong integer, ushort fraction, char sign)  // MAdd1
    {
        this._integer += integer;
        this._fraction += fraction;
        if (this._integer < integer)
        {
            this._sign = sign;
        }
    }

    public void Addition2(Money money)   // MAdd2
    {
        this._integer += money._integer;
        this._fraction += money._fraction;
        if (this._integer < money._integer)
        {
            this._sign = money._sign;
        }
    }

    public bool CheckSubtraction(ulong integer, ushort fraction)
    {
        if (this._integer < integer)
        {
            return false;
        }
        else if (this._integer == integer)
        {
            if (this._fraction < fraction)
            {
                return false;
            }
        }
        return true;
    }


    public void Subtraction(ulong integer, ushort fraction)   // MSub1
    {
        if (CheckSubtraction(integer, fraction))
        {

            this._integer -= integer;
            this._fraction -= fraction;
            AddToFraction();
        }
        else
            Console.WriteLine("We can't perform a substruction");
    }

    public void Subtraction2(Money obj)       //  MSub2
    {
        if (CheckSubtraction(obj._integer, obj._fraction))
        {

            this._integer -= obj._integer;
            this._fraction -= obj._fraction;
            AddToFraction();
        }
        else
            Console.WriteLine("We can't perform a substruction");
    }


    public bool MoneyEqual(Money money)    //  MEq
    {
        if (money._integer.Equals(this._integer) && money._fraction.Equals(this._fraction) && money._currency.Equals(this._currency) && money._sign.Equals(this._sign))
        {
            return true;
        }
        return false;
    }

    public int MoneyCompare(Money money)     // MComp
    {
        // TODO
        return 1;
    }

    public void ConvertMoney(Money money)
    {
        this._integer *= money._integer;
        this._fraction *= money._fraction;
        this._currency = money._currency;
    }

}