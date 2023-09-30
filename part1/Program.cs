struct Vector
{
    int x, y, z;

    public Vector(int x, int y, int z)
    {
        this.x = x; this.y = y; this.z = z;
    }
    public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
    public static Vector operator *(Vector a, int b) => new Vector(a.x * b, a.y * b, a.z * b);
    public static bool operator ==(Vector a, Vector b) 
    {
        if (a.leight() == b.leight()) 
            return true;
        return false;
    } 
    public static bool operator !=(Vector a, Vector b)
    {
        if (a.leight() != b.leight())
            return true;
        return false;
    }
    public static bool operator >(Vector a, Vector b)
    {
        if (a.leight() > b.leight())
            return true;
        return false;
    }
    public static bool operator <(Vector a, Vector b)
    {
        if (a.leight() < b.leight())
            return true;
        return false;
    }
    public static bool operator >=(Vector a, Vector b)
    {
        if (a.leight() >= b.leight())
            return true;
        return false;
    }
    public static bool operator <=(Vector a, Vector b)
    {
        if (a.leight() <= b.leight())
            return true;
        return false;
    }
    public int leight() => (int)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
}