interface IEquatable<Car>
{
    public bool Equals( Car other );
}

public class Car : IEquatable<Car>
{
    public string Name;
    public string Engine;
    public int MaxSpeed;

    public override string ToString()
    {
        return Name;
    }


    public Car( string Name, string Engine, int MaxSpeed )
    {
        this.Name = Name;
        this.Engine = Engine;
        this.MaxSpeed = MaxSpeed;
    }

    public bool Equals( Car other )
    {
        throw new NotImplementedException();
    }
}


public class CarsCatalog
{
    private List<Car> cars;


    public CarsCatalog( params Car[] pars )
    {
        this.cars = new();
        for (var x = 0; x < pars.Length; ++x)
        {
            this.cars.Add( new Car( pars[x].Name, pars[x].Engine, pars[x].MaxSpeed ) );
        }
    }


    public string this[int index]
    {

        get
        {
            if (index >= 0) return $"{cars[index].Name} - {cars[index].Engine}";
            else return $"{cars[System.Math.Abs( (cars.Count + index) ) % cars.Count].Name} - {cars[(cars.Count - index) % cars.Count].Engine} ";
        }
    }
}



public class Task2
{
    public static void Main( string[] args )
    {
        CarsCatalog carsCatalog = new CarsCatalog( new Car("Audi", "V12", 500), 
                                                   new Car("BMW", "V8",350), 
                                                   new Car("Mazda","V6",250) );

        Console.WriteLine( carsCatalog[0] );
        Console.WriteLine( carsCatalog[-5] );
    }
}
