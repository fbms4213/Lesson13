using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson13_4;


// Boxing, Unboxing
// Collection


class Program
{
    static void Main()
    {
        // // Reference type => Reference type (Nothing)
        // // string str = "World";
        // // object obj = str;
        // 
        // 
        // 
        // // Value type => Reference type (Boxing)
        // 
        // int num = 10;
        // object obj = num;
        // 
        // 
        // // Reference type => Value type (UnBoxing)
        // 
        // int unBoxing = (int)obj;
        // Console.WriteLine(unBoxing);






        // Collection (object)
        // GenericCollection
        // ThreadSafeCollection







        // // List<int> listRange = new() { 11, 22, 33, 11, 22, 33, 44, 55 };
        // // List<int> list = new List<int>();
        // List<int> list = new List<int>(3);
        // 
        // list.Add(1);
        // list.Add(2);
        // list.Add(3);
        // // list.AddRange(listRange);
        // 
        // 
        // 
        // foreach (var item in list)
        //     Console.WriteLine(item);
        // 
        // 
        // Console.WriteLine(list.Count);
        // Console.WriteLine(list.Capacity);
        // 
        // // list.Clear();




        // ArrayList list = new ArrayList();
        // list.Add("Hello");
        // list.Add(1);
        // list.Add(true);
        // list.Add(1.5);
        // list.Add(new DateOnly(2002, 2, 3));
        // 
        // 
        // foreach (var i in list)
        //     Console.WriteLine(i);





        Queue queue = new Queue(Enumerable.Range(10, 5).ToList());
        Queue<int> queueGen = new Queue<int>();

        // foreach (var i in queue)
        //     Console.WriteLine(i);





        Stack stack = new Stack(Enumerable.Range(10, 5).ToList());
        Stack<int> stackGen = new Stack<int>();

        // foreach (var s in stack)
        //     Console.WriteLine(s);



        // Dictionary<int, string> map = new();
        // map.Add(5, "Emin");
        // map.Add(3, "Nihat");
        // map.Add(7, "Miri");
        // 
        // foreach (var i in map)
        // {
        //     Console.WriteLine(i);
        //     Console.WriteLine(i.Key);
        //     Console.WriteLine(i.Value);
        // }



        // Hashtable hashtable = new();
        // hashtable.Add(5, "Emin");
        // hashtable.Add(3, "Nihat");
        // hashtable.Add(7, "Miri");
        // 
        // foreach (DictionaryEntry i in hashtable)
        // {
        //     Console.WriteLine(i.Key);
        //     Console.WriteLine(i.Value);
        // }




        // LinkedList<int> list = new LinkedList<int>();


        // SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
         
        // HashSet<int> visited = new HashSet<int>();


    }
}