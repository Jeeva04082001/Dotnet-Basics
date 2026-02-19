1️⃣ Class na enna?
👉 Class = blueprint / design

Real life example:

Class = House plan
Object = Actual house


2️⃣ Simple Class example


class Person
{
    public string Name;
    public int Age;
}  



class Person
{
    public string Name;
    public int Age;
}  

3️⃣ Object na enna?
👉 Class-oda real instance

Person p1 = new Person();

new → memory create pannum
p1 → object reference

4️⃣ Assign values to object

p1.Name = "Jeeva";
p1.Age = 24;

5️⃣ Print object data

Console.WriteLine(p1.Name);
Console.WriteLine(p1.Age);

6️⃣ Method inside class


class Person
{
    public string Name;
    public int Age;

    public void Greet()
    {
        Console.WriteLine($"Hi, I am {Name}. my age is {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.Name = "Jeeva";
        p1.Age = 14;
        p1.Greet();
    }
}




class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Greet()
    {
        Console.WriteLine($"Hi, I am {Name}. my age is {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("jeeva",24);
        p1.Greet();
    }
}


---------------PRACTICE TASKS

Task 1️⃣
Create class Car
    Properties: Brand, Speed
    Method: ShowDetails()

Task 2️⃣
    Create object
    Set values
    Call method


Task 3️⃣
Create 2 objects with different values





class Car
{
    public string Brand;
    public int Speed;

    public Car(string brand, int speed)
    {
        Brand=brand;
        Speed=speed;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Car Brand is {Brand} and it's speed is {Speed}Km / hrs  ");
    }
}



class Program
{
    static void Main()
    {
        Car c1 = new Car("OTO",200);
        c1.ShowDetails();

        Car c2 = new Car("BMW", 250);
        c2.ShowDetails();

    }
}



class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        cars.Add(new Car("Toyota",200));
        cars.Add(new Car("BMW",250));
        cars.Add(new Car("Audi",150));

        foreach(Car car in cars)
        {
            car.ShowDetails();

        }
    }


}



class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        cars.Add(new Car("Toyota",200));
        cars.Add(new Car("BMW",250));
        cars.Add(new Car("Audi",150));

        foreach(Car car in cars)
        {
            if (car.Speed >= 200)
            {
            car.ShowDetails();

            }
        }

        Console.WriteLine(cars.Count);

    }


}


1️⃣ Constructor na enna?

👉 Object create pannum bodhu automatic-aa call aagura special method

Person p = new Person();
👉 new Person() → constructor call

2️⃣ Constructor rules (remember this 🔒)

Class name = constructor name
Return type illa (not even void)
Object create panna automatic-aa run aagum


3️⃣ -----------PRACTICE TASKS--------Simple constructor example--------------

Task 1️⃣
Create class Student
Properties: Name, Marks
Constructor to initialize
Method: ShowResult()

Task 2️⃣
Create 2 Student objects
Different values
Call method

class Student
{
    public string Name;
    public int Marks;

    public Student(string name, int marks)
    {
        Name=name;
        Marks=marks;
    }

    public void ShowResult()
    {
        Console.WriteLine($"Student Name : {Name}. Scored {Marks}");
        
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Jeeva", 89);
        s1.ShowResult();

        Student s2=new Student("Jeni",98);
        s2.ShowResult();
    }
}












