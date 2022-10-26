struct Vector
{
    private double x, y, z;

    public Vector( double x, double y, double z )
    {
        this.x = x; this.y = y; this.z = z;
    }

    public static Vector operator +( Vector first, Vector second )
    {
        return new Vector( first.x + second.x, first.y + second.y, first.z + second.z );
    }

    public static Vector operator *( Vector vec, double multiplier )
    {
        return new Vector( vec.x * multiplier, vec.y * multiplier, vec.z * multiplier );
    }

    public static double operator *( Vector first, Vector second )
    {
        return first.x * second.x + first.y * second.y + first.z * second.z;
    }

    public static bool operator ==( Vector first, Vector second )
    {
        return Vector.Abs( first ) == Vector.Abs( second );
    }

    public static bool operator !=( Vector first, Vector second )
    {
        return !(first == second);
    }

    public static bool operator >( Vector first, Vector second )
    {
        return Vector.Abs( first ) > Vector.Abs( second );
    }

    public static bool operator <( Vector first, Vector second )
    {
        return Vector.Abs( first ) < Vector.Abs( second );
    }

    public static bool operator >=( Vector first, Vector second )
    {
        return Vector.Abs( first ) >= Vector.Abs( second );
    }

    public static bool operator <=( Vector first, Vector second )
    {
        return Vector.Abs( first ) <= Vector.Abs( second );
    }

    public static void Print( Vector vec )
    {

        Console.WriteLine( vec.x + " " + vec.y + " " + vec.z );
    }


    public static double Abs( Vector vec )
    {
        return Math.Sqrt( vec.x * vec.x + vec.y * vec.y + vec.z * vec.z );
    }

}

public class Task1
{
    public static void Main( string[] args )
    {
        Vector first = new Vector(1, 2, 4);

        Vector second = new Vector(-1, 0, 1);

        Console.WriteLine( "First vector:" );
        Vector.Print( first );


        Console.WriteLine( "Second vector:" );
        Vector.Print( second );


        Console.WriteLine( $"\nVector sum " );
        Vector.Print( first + second );

        Console.WriteLine( "Multiply first vector by 3" );
        Vector.Print( first * 3 );

        Console.WriteLine( "Multiply first vector by second vector" );
        Console.WriteLine( first * second );

        Console.WriteLine( $"\nFirst > Second : {first > second}\n" +
            $"Fisrt < Second : {first < second}\n" +
            $"First >= Second : {first >= second}\n" +
            $"First <= Second : {first <= second}\n" +
            $"First >= Second : {first >= second}\n" +
            $"First == Second : {first == second}\n" +
            $"First != Second : {first != second}\n" );
    }
}
