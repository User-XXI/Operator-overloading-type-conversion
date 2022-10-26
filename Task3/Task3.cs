public class Task3
{
    public abstract class Currency
    {
        protected double value;
    }


    public class CurrencyRUB : Currency
    {
        public CurrencyRUB( double value )
        {
            this.value = value;
        }


        public static implicit operator CurrencyUSD( CurrencyRUB cur )
        {
            return new CurrencyUSD( cur.Value / CurrencyUSD.ExchangeRate );
        }

        public static implicit operator CurrencyEUR( CurrencyRUB cur )
        {
            return new CurrencyEUR( cur.Value / CurrencyEUR.ExchangeRate );
        }

        public double Value
        {
            get { return this.value; }
        }
    }


    public class CurrencyEUR : Currency
    {

        public static double ExchangeRate { get; set; }


        public static implicit operator CurrencyRUB( CurrencyEUR cur )
        {
            return new CurrencyRUB( cur.Value * CurrencyEUR.ExchangeRate );
        }

        public static implicit operator CurrencyUSD( CurrencyEUR cur )
        {
            return new CurrencyUSD( cur.Value * CurrencyEUR.ExchangeRate / CurrencyUSD.ExchangeRate );
        }


        public CurrencyEUR( double value )
        {
            this.value = value;
        }
        public double Value
        {
            get { return this.value; }
        }
    }

    public class CurrencyUSD : Currency
    {

        public static double ExchangeRate { get; set; }

        public static implicit operator CurrencyRUB( CurrencyUSD cur )
        {
            return new CurrencyRUB( cur.Value / CurrencyUSD.ExchangeRate );
        }

        public static implicit operator CurrencyEUR( CurrencyUSD cur )
        {
            return new CurrencyEUR( cur.Value / CurrencyUSD.ExchangeRate / CurrencyEUR.ExchangeRate );
        }


        public CurrencyUSD( double value )
        {
            this.value = value;
        }

        public double Value
        {
            get { return this.value; }
        }
    }

    public static void Main( string[] args )
    {

        CurrencyUSD.ExchangeRate = 58.18;
        CurrencyEUR.ExchangeRate = 55.99;


        CurrencyRUB rub = new CurrencyRUB(10000);
        Console.WriteLine( "There are {0} RUB in your pocket", rub.Value );
        CurrencyEUR eur = rub;
        Console.WriteLine( $"It's {eur.Value} EUR" );
        CurrencyUSD usd = eur;
        Console.WriteLine( $"It's {usd.Value} USD" );
    }
}
