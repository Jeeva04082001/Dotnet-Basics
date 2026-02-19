18-02-2025

1️⃣ Arithmetic Operators

int a = 20;
int b = 3;

Console.WriteLine(a+b);
Console.WriteLine(a-b);
Console.WriteLine(a*b);
Console.WriteLine(a/b);
Console.WriteLine(a%b);

==========================================

2️⃣ Comparison Operators

int age = 20;
Console.WriteLine(age >=18);
Console.WriteLine(age == 20);
Console.WriteLine(age != 25);
Console.WriteLine(age <= 18);


==========================================

3️⃣ Logical Operators

int age = 15;
bool hasId = true;

if (age >= 18 && hasId)
{
    Console.WriteLine("Allowed");
}


IF / ELSE

4️⃣ Simple if

int num = 10;

if (num > 5)
{
    Console.WriteLine("num is greter than 5");
}

5️⃣ if – else

int age = 20;

if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}


6️⃣ else if

int mark = 60;

if (mark >= 90)
{
    Console.WriteLine("A Grade");
}
else if (mark >= 60)
{
    Console.WriteLine("B Grade");
}
else
{
    Console.WriteLine("Fail");
}

================== Tasks =======================================


Task 1:-  Check number even or odd

int num=24;

if (num % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

==================================================

Task 2:-

Check age:
    <18 → Minor
    18–60 → Adult
    60 → Senior

int age = 40;
if (age < 18)
{
    Console.WriteLine("Minor");
}
else if (age >= 18 && age <= 60)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Senior");
}


Task 3 :- Compare two numbers and print greater one.

int num1 = 10;
int num2 = 20;

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}


Console.WriteLine(num1 > num2 ? num1 : num2);

=============================================================


