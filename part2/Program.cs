public struct Car : IEquatable<Car>
{
    public string Name;
    public string Engine;
    int MaxSpeed;

    public Car(string v1, string v2, int v3)
    {
        Name = v1;
        Engine = v2;
        MaxSpeed = v3;
    }
    public override string ToString() => $"{Name}";
    bool IEquatable<Car>.Equals(Car other)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj) => this == obj as Car?;
    public static bool operator ==(Car? left, Car? right) =>
    left?.Name == right?.Name && left?.Engine == right?.Engine && left?.MaxSpeed == right?.MaxSpeed;
    public static bool operator !=(Car? left, Car? right) => !(left == right);
}

class CarsCatalog 
{
    Car[] cars;
    public int leight;
    public CarsCatalog(int size) 
    {
        cars = new Car[size];
        leight = size;
    }
    public CarsCatalog(Car[] cars, int size)
    {
        this.cars = cars;
        leight = size;
    }
    public string this[int index]
    {
        get 
        {
            string str = $"Name: {cars[index].Name} Engine: {cars[index].Name}";
            return str;
        } 
    }
}