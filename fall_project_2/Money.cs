using fall_project_2.enums;

namespace fall_project_2;

// TODO Iheritance  IEquatable<Money> and IComparable<Money>
public class Money //: IEquatable<Money>, IComparable<Money>
  {
    private Random random = new Random();

    private currencyEnum currencies; 

    private ulong integer;
    private ushort fraction;

    private char sign;

    private string currency;

    public ulong GetInteger()
    {

      return this.integer; // AM1
    }

    public char GetSign()
    {
      return this.sign; // AM2
    }
    public ushort GetFraction()
    {
      return this.fraction; // AM3
    }

    public void addToFraction()
    {
      this.integer += (ushort)(this.fraction / 100);
      this.fraction = (ushort)(this.fraction % 100);
    }

    public void DisplayToConsole()
    {
      Console.WriteLine("{0}.{1}", this.integer, this.fraction); // MD
    }
    public void SetInteger(ulong value)
    {
      integer = value; // MS1
    }
    public void SetFraction(ushort value)
    {
      fraction = value; // MS2
    }

    public void SetSign(char sign) // MS3
    {
      this.sign = sign;
    }

    public Money() //  C1
    {
      this.integer = (ulong)random.Next(1, 112) - 4;
      this.fraction = (ushort)(random.Next(1, 156) * random.Next(3, 7));
      // this.currency = currencies[random.Next(currencies.Count)];
    }

    public Money(ushort fraction, ulong integer, string currency, char sign) // C2
    {
      this.fraction = fraction;
      this.integer = integer;
      this.currency = currency;
      this.sign = sign;
    }
    public Money(Money money) // C3
    {
      this.integer = money.integer;
      this.fraction = money.fraction;
      this.currency = money.currency;
      this.sign = money.sign;
    }

    public Money(string money) // C4
    {
      String[] newValue = money.Split('.');
      this.integer = Convert.ToUInt64(newValue[0]);
      this.fraction = Convert.ToUInt16(newValue[1]);
      this.sign = getSignOfNumber(money);

    }

    public char getSignOfNumber(string number)
    {
      if (number[0] == '-')
      {
        return '-';
      }

      return '+';
    }

    public void Addition(ulong integer, ushort fraction, char sign)  // MAdd1
    {
      this.integer += integer;
      this.fraction += fraction;
      if (this.integer < integer)
      {
        this.sign = sign;
      }
    }

    public void Addition2(Money money)   // MAdd2
    {
      this.integer += money.integer;
      this.fraction += money.fraction;
      if (this.integer < money.integer)
      {
        this.sign = money.sign;
      }
    }

    public bool checkSubtraction(ulong integer, ushort fraction)
    {
      if (this.integer < integer)
      {
        return false;
      }
      else if (this.integer == integer)
      {
        if (this.fraction < fraction)
        {
          return false;
        }
      }
      return true;
    }


    public void Subtraction(ulong integer, ushort fraction)   // MSub1
    {
      if (checkSubtraction(integer, fraction))
      {

        this.integer -= integer;
        this.fraction -= fraction;
        addToFraction();
      }
      else
        Console.WriteLine("We can't perform a substruction");
    }

    public void Subtraction2(Money obj)       //  MSub2
    {
      if (checkSubtraction(obj.integer, obj.fraction))
      {

        this.integer -= obj.integer;
        this.fraction -= obj.fraction;
        addToFraction();
      }
      else
        Console.WriteLine("We can't perform a substruction");
    }


    public bool MoneyEqual(Money money)    //  MEq
    {
      if (money.integer.Equals(this.integer) && money.fraction.Equals(this.fraction) && money.currency.Equals(this.currency) && money.sign.Equals(this.sign))
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

    public void convertMoney(Money money)
    {
      this.integer *= money.integer;
      this.fraction *= money.fraction;
      this.currency = money.currency;
    }

  }