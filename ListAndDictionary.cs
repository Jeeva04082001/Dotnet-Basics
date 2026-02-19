1️⃣ List – recap (short)
List = multiple values (same type)


List<int> nums = new List<int>{1,2,3,4,5};
nums.Add(6);
foreach (int n in nums)
{
    Console.WriteLine(n);
}


2️⃣ Dictionary – NEW CONCEPT 🔑
👉 Key – Value pair

Real life:

    RollNo → Name
    Email → Password
    ProductId → Price

===================================================

Meaning:
    int → key
    string → value

Dictionary<int, string> students = new Dictionary<int, string>();

students.Add(1,"jeeva");
students.Add(2,"jeni");

Console.WriteLine(students[1]);

foreach(var ite in students)
{
    Console.WriteLine($"Key: {ite.Key} Value: {ite.Value}");
}




Dictionary<int,string> Persons = new Dictionary<int,string>();
Persons.Add(1,"Hari");
Persons.Add(2,"Kalai");

Console.WriteLine(Persons[2]);

foreach(var item in Persons)
{
    Console.WriteLine($"Key : {item.Key}  Value: {item.Value}");
}


class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name=name;
        Age=age;
    }

    public void Show()
    {
        Console.WriteLine($"Name is {Name} Age is {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Kavi",24);
        p1.Show();

        
    }
}

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name=name;
        Age=age;
    }

    public void Show()
    {
        Console.WriteLine($"Name is {Name} Age is {Age}");
    }
}



class Program
{
    static void Main()
    {
        Dictionary<int, Person> persons = new Dictionary<int, Person>();
        persons.Add(1, new Person("Mani",23));
        persons.Add(2, new Person("Kani", 24));
        persons.Add(3, new Person("Jeni", 18));

        // persons[2].Show(); // access one item

        foreach(var item in persons)
        {
            
            Console.WriteLine($"Key: {item.Key}");
            item.Value.Show();
                
           
            
        }
    }
}



class Program
{
    static void Main()
    {
        Dictionary<int, Person> persons = new Dictionary<int, Person>();
        persons.Add(1, new Person("Mani",23));
        persons.Add(2, new Person("Kani", 24));
        persons.Add(3, new Person("Jeni", 18));

        // persons[2].Show(); // access one item

        foreach(var item in persons)
        {
            if (item.Value.Age >= 20)
            {
                Console.WriteLine($"Key: {item.Key}");
                item.Value.Show();
                
            }
            
        }
        Console.WriteLine($"Total Count : {persons.Count}");
    }
}

