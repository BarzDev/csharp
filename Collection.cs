using System;
using System.Collections;


namespace ConsoleApp1;
public class Collection
{
    public void Main(string[] args)
    {
        /*
        Collection mirip array dan ada banyak macamnya
        Keunggulan dari Collection :
        - Menambah data terus menerus
        - Flexible
        - Bisa mengoperasikan CRUD, retrive, dan sort
        */

        /*
        List --> mirip seperti array bedanya dia flexible dan lebih mudah kita operasikan CRUD
        HashSet --> untuk menyimpan data hanya menyimpan unique value
        HashTable --> yang menyimpan datanya berupa key dan value
        Dictionary --> menyimpan data berupa key dan value,, bedanya generic
        */

    SortedList();

    }

    private static void SortedList()
    {
        var sortedList = new SortedList
        {
            {1, "Jakarta"},
            {4, false},
            {2, 1},
        };

        var sortedDictionary = new SortedDictionary<string, string>();
        var sortedHashSet = new SortedSet<string>();

        foreach (DictionaryEntry o in sortedList)
        {
            Console.WriteLine($"{o.Key} - {o.Value}");
        }

        sortedHashSet.Add("Jution");
        sortedHashSet.Add("Jution");
        sortedHashSet.Add("Doni");

        foreach (var name in sortedHashSet)
        {
            Console.WriteLine(name);
        }
    }

    private static void Dictionary()
    {
        var cities = new Dictionary<string, string>();
        cities.Add("Indonesia","Jakarta");
        cities.Add("Thailand","Bangkok");
        cities.Add("Malaysia","Kuala Lumpur");

        // pemanggilan looping
        foreach (var pair in cities)
        {
            Console.WriteLine($"Key: {pair.Key} - Value : {pair.Key}");
        }
    }

    private static void HashTable()
    {
        var hashtable = new Hashtable();
        hashtable.Add(1, "Jakarta");
        hashtable.Add("2", 1);
        hashtable.Add(true, false);

        // cara panggil looping
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
        }

        // update hashtable
        hashtable[1] = "Bandung";
        hashtable["2"]=1;
        hashtable[true]= "Jakarta";

        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
        }
        

        // delete hashtable
        hashtable.Remove(true);

    }
    private static void HashSet()
    {
        var names = new HashSet<string>();
        names.Add("Jution");
        names.Add("Stefano");
        names.Add("Fadli");
        names.Add("Fadli");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    private static void List(){

    /* Cara 1 */
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

         /* Cara Looping */
        // foreach (var number in numbers)
        // {
        //     Console.WriteLine($"angka: {number}");
        // }
        // Console.WriteLine(numbers);

    /* Cara 2 : mengisi langsung */
        var cities = new List<string>
        {
            "Jakarta",
            "Bandung",
            "Depok",
        };
        /* Cara Looping */
        // for (var i = 0; i < cities.Count; i++)
        // {
        //     Console.WriteLine(cities[i]);
        // }

    /* UPDATE data*/
        Console.WriteLine($"city 2: {cities[2]}");
        cities[2]= "Medan";
        Console.WriteLine($"city 2: {cities[2]}");
 
    /* DELETE data*/
        cities.RemoveAt(0);  // mengahpus dari index
        cities.Remove("Medan"); // menghapus nama data
    }
}

