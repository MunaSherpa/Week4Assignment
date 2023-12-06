public class Shape
{
    public virtual int CalculateArea()
    {
        return 0;
    }

}

public class Circle : Shape
{
    public int radius;
    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override int CalculateArea()
    {
        var area = (int)(15 * radius * radius);
        Console.WriteLine("The area of given radius " + area);
        return area;
    }
}