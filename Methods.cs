1️⃣ Method na enna?
👉 Oru velai-ya thaniyaa ezhudhi, theva padum podhu call pannradhu

----------- Python:
def add(a, b):
    return a + b

----------- C#:

static int Add(int a, int b)
{
    return a+b;
}
int a = Add(2,3);
Console.WriteLine(a);

static → object create pannaama call panna
int → return type
Add → method name
(int a, int b) → parameters
return → value back kudukkum

2️⃣ Simple method example

static void SayHello()
{
    Console.WriteLine("hello world");
}
SayHello();


3️⃣ Method structure (breakdown)
static int Add(int a, int b)
{
    return a + b;
}


4️⃣ Method with return value

static int Square(int n)
{
    return n*n;
}
int res = Square(5);
Console.WriteLine(res);

5️⃣ Method without return (void)

static void PrintEven(int n)
{
    if (n%2 == 0)
    {
        Console.WriteLine($"{n} in Even number");
    }
}
PrintEven(4);


6️⃣ Using method with List (VERY IMPORTANT 🔥)

Your previous logic-a method-la podalaam 👇

static void PrintEvenAndSum(List<int> nums)
{
    int sum=0;
    foreach(int n in nums)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine(n);
        }
        sum+=n;
    }

}
List<int> nums = new List<int>{1,2,3,4,5,6};
PrintEvenAndSum(nums);


def func():        ↔  static void Func()
return value       ↔  return value


---------------PRACTICE TASKS-------------

Task 1️⃣ : Add 2 nums


static int Add(int a, int b)
{
    return a+b;
}
int n = Add(2,5);
Console.WriteLine(n);


Task 2️⃣ : print odd numbers in list


static void PrintOdd(List <int> nums)
{
    foreach(int n in nums)
    {
        if(n%2 != 0)
        {
            Console.WriteLine(n);
        }
    }

}

List<int> nums = new List<int>{1,2,3,4,5,6,7};
PrintOdd(nums);


Task 3️⃣ Find maximum number in a list


static int FindMax(List<int> nums)
{
    if (nums.Count == 0)
    {
        Console.WriteLine("List is empty");
        return -1;
    }
    int max = nums[0];
    foreach(int n in nums)
    {
        if (n > max)
        {
            max = n;
        }
        
        
    }
    return max;  
}
List<int> nums = new List<int> {1,2,3,4,5,6};
int res = FindMax(nums);
Console.WriteLine($"Maximum number is {res}");




