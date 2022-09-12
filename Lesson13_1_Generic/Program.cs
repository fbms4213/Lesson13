namespace Lesson13_1_Generic;


#nullable disable





struct KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public void Deconstruct(out TKey key, out TValue value)
    {
        key = Key;
        value = Value;
    }
}




// Constraints

// struct - value type
// class - reference type
// new() - must be default constructor (default olmayan, delegate-, interface-)
// Base class, Base interface
// Base class Two Type parameter (T : B)

// unmanaged
// default
// notnull


class Base { }
class Derived1 : Base { }
class Derived2 : Base { }





class Some<T, B> where T : B
{
    public T Data { get; set; }

    public void GetData<TParam>(TParam param) where TParam : new()
    {
        Console.WriteLine(param);
        TParam obj = new TParam();

        // T test = default;
        // T test = default(T);
    }
}



delegate void MyDel();
delegate void MyDel<T>();




// interface IRequest<T> { }
// interface IRequest<in T> { }
// interface IRequest<out T> { }

interface IRequest { }
interface IRequestHandler : IRequest { }



class Any : IRequest { }
// class Any : IRequestHandler { }



class Program
{
    static void Main()
    {
        Some<Any, IRequest> some = new();


        // Some<MyDel> some = new();
        // Some<string> some = new();
        // Some<IResquest> some = new();






        // Some<int> some = new();
        // some.Data = 1;
        // 
        // some.GetData("Test1");
        // some.GetData<string>("Test2");



        /////////////////////////////////




        // // Some<int> some = new();
        // Some<string> some = new Some<string>();
        // 
        // some.Data = "Hello";
        // 
        // Console.WriteLine(some.Data);



        /////////////////////////////////




        // var pair = new KeyValuePair<int, string>();
        // 
        // pair.Key = 1;
        // pair.Value = "New";
        // 
        // 
        // var (x, y) = pair;
        // Console.WriteLine(x);
        // Console.WriteLine(y);
        // 
        // Console.WriteLine(pair.Key);
        // Console.WriteLine(pair.Value);
    }
}