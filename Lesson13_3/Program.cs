namespace Lesson13_3;


class Program
{
    static IEnumerable<int> ExampleYield()
    {
        yield return 1;
        yield return 3;
        yield return 5;


        // if (false)
        //     yield break;


        yield return 7;
        yield return 9;
    }





    static void Main()
    {

        //// yield
        // foreach (var i in ExampleYield())
        //     Console.WriteLine(i);






        //// Iterator
        List<int> list = Enumerable.Range(5, 10).ToList();

        IEnumerator<int> iterator = list.GetEnumerator();

        while (iterator.MoveNext())
            Console.WriteLine(iterator.Current);


        iterator.Reset();


        while (iterator.MoveNext())
            Console.WriteLine(iterator.Current);
    }
}