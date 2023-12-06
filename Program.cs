public class Program
{
    public static void Main(string[] args)
    {
        //ex-1
        Car obj = new Car("Audi", 2023, 1300.22f);
        obj.printCarDetails();


        //ex-2
        BankAccount accountObj = new BankAccount("09999999999", 0);

        accountObj.Deposite(30000);
        accountObj.Withdraw(10000);
        accountObj.finalBanace();

        //ex-3
        Rectangle rectObj = new Rectangle(15, 20);
        rectObj.CalculateArea();

        //ex-4
        Circle areaObj = new Circle(5);
        areaObj.CalculateArea();

        //ex-5
        Student studentObj = new Student("John Doe", 20, "Computer Science");
        studentObj.Introduce();

        //ex-6
        Stack<int> stackObj = new Stack<int>();
        stackObj.Push(6);
        stackObj.Push(4);
        stackObj.Push(2);
        stackObj.Pop();
        stackObj.Peek();
        stackObj.isEmpty();

        //ex-7
        Calendar calendar = new Calendar();

        calendar.PrintWeekdays();

        //ex-8
        Point2D pointA = new Point2D { X = 4.0f, Y = 9.0f };
        Point2D pointB = new Point2D { X = 6.0f, Y = 3.0f };


        float distance = DistanceCalculator.CalculateDistance(pointA, pointB);


        Console.WriteLine($"Distance between Point A and B: {distance}");
    }

    
}