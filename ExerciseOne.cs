public class Car
{
    private string brand;
    private int year;
    private float price;


    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    public void printCarDetails()
    {
        Console.WriteLine("The brand of the car: " + brand);
        Console.WriteLine("The model year: " + year);
        Console.WriteLine("The car price: Rs " + price);

    }
}