1️⃣ Exception na enna?
👉 Runtime error
Program run aagumbodhu problem vandhaa exception varum.


try
{
    // risky code
}
catch
{
    // error handle
}

👉 try-la error vandhaa → catch execute aagum
👉 Program crash aagathu ✅


3️⃣ Simple example

try
{
    int num = int.Parse("anb");
    Console.WriteLine(num);
}
catch
{
    Console.WriteLine("Invalid Input!");
}


4️⃣ Real-life example (divide by zero)

try
{
    int a = 10;
    int b = 0;
    Console.WriteLine(a/b);
}
catch
{
    Console.WriteLine("Cannot divide by Zero!");
}


5️⃣ Catch with Exception object

try
{
    int num = int.Parse("20.22");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



6️⃣ finally block (IMPORTANT)
👉 Error vandhaalum varalaalum always execute aagum

try
{
    Console.WriteLine("Try block");
}
catch
{
    Console.WriteLine("Catch block");
}
finally
{
    Console.WriteLine("Finally block");
}


7️⃣ Multiple catch (basic idea)

try
{
    int[] nums = {1,2,3,4};
    Console.WriteLine(nums[4]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Index Error");

}
catch (Exception)
{
    Console.WriteLine("Some error Occured");
}


---------------------- 🧪 PRACTICE TASKS (DO THIS 🔥)


Task 1️⃣
    Convert string "100a" to int
    Handle error using try–catch.


try
{
    int num = int.Parse("100a");
    Console.WriteLine(num);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);

}

Task 2️⃣
    Create array {1,2,3}
    Try to access index 5
    Handle exception.

Task 3️⃣
    Use finally block and print "Program ended".

try
{
    int[] nums = {1,2,3,4};
    Console.WriteLine(nums[5]);
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine("Index out of range");
}
finally
{
    Console.WriteLine("Program ended");
}



