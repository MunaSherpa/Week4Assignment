public class Student
{
    private string name;
    private int age;
    private string major;


    public Student(string name, int age, string major)
    {
        this.name = name;
        this.age = age;
        this.major = major;
    }

    public void Introduce()
    {
        Console.WriteLine("my name is" + name + "I am" + age + "year old and my major is " + major);
    }
}