public class Rectangle
{
    private float length;
    private float width;

    public Rectangle(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    public float CalculateArea()
    {
        var area = length * width;
        Console.WriteLine(" The are of Rectangle is" + area);
        return area;
    }
}