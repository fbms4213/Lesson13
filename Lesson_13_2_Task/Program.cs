namespace Lesson_13_2_Task;

#nullable disable

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

}

class Program
{
    static void DoSomething(Action<Student> action)
    {
        var s = new Student();

        action.Invoke(s);

        Console.WriteLine(s.Id);
        Console.WriteLine(s.Name);
        Console.WriteLine(s.Surname);
    }


    static void Main()
    {
        DoSomething(s =>
        {
            s.Id = 1;
            s.Name = "Emin";
        });
    }
}