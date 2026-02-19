// 19-02-2025


// 1️⃣ for loop
// for (int i =1; i <=5; i++)
// {
//     Console.WriteLine(i);
// }


// 2️⃣ while loop

// int i =1;
// while (i <= 5)
// {
//     Console.WriteLine(i);
//     i++;
// }


// 3️⃣ foreach loop

// int [] nums = {10,20,30};

// foreach(int n in nums)
// {
//     Console.WriteLine(n);
// }


// 🧠 1️⃣ int[] nums = {20,30,40} — ARRAY
// int[] nums = { 20, 30, 40 };

// 🧠 2️⃣ List C#-la ipdi irukkum (different)
// If List venumna, syntax different 👇

// List<int> nums = new List<int> { 20, 30, 40 };


// 🧠 Memory trick:-
//     int[] → Fixed size
//     List<int> → Dynamic size
//     Add() → List only

// --------------PRACTICE TASKS-------------

// Task 1 :- Print numbers 1 to 10


// for (int i=1; i<=10; i++)
// {
//     Console.WriteLine(i);
// }


// int j=1;
// while(j<=10)
// {
//     Console.WriteLine(j);
//     j++;
// }

// Task 2 :- Print even numbers from 1 to 20


// for(int i =1; i<=20; i++)
// {
//     if(i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// int i=1;
// while (i <= 20)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
        
//     }
//     i++;
// }

// Task 3 :- Print multiplication table of 5


// for(int i=1; i<=10; i++)
// {
//     Console.WriteLine($"{i} * 5 = {i*5}");
// }

// int i=1;
// while (i <= 10)
// {
//     Console.WriteLine($"{i} * 5 = {i*5}");
//     i++;
// }

// Task 4 :- Change array values:

// int[] nums = { 5, 15, 25 };
// nums[1]=10;
// nums[2]=15;

// foreach(int n in nums)
// {
//     Console.WriteLine(n);
// }



// Task 5:-  Print double of each number:


// int [] nums = {1,2,3,4};
// foreach(int n in nums)
// {
//     Console.WriteLine(n);
// }

// Task 6:- ADD values → use List

// List <int> nums = new List<int> {1,2,3,4};
// nums.Add(5);
// foreach(int n in nums)
// {
//     Console.WriteLine(n);
// }


// 🎯 Small practice (do this)

// 1️⃣ Array-la second value change pannunga

// int [] nums = {1,2,4,4,5};
// nums[2]=3;
// foreach(int n in nums)
// {
//     Console.WriteLine(n);
// }


// 2️⃣ Same values-oda List create pannunga

// List <int> nums = new List <int> {1,2,3,4,5};



// 3️⃣ List-la new value add pannunga

// List <int> nums = new List <int> {1,2,3,4,5};
// nums.Add(6);
// foreach(int n in nums)
// {
//     Console.WriteLine(n);
// }
// Console.WriteLine("Total Count : "+ nums.Count);


// 🎯 Small extra practice (try pannunga)

// 1️⃣ Only even numbers print pannunga
// 2️⃣ List-la irukkura sum calculate pannunga



// List <int> nums = new List<int>{1,2,3,4,5,6};
// int sum =0;
// foreach(int n in nums)
// {
//     if (n % 2 == 0)
//     {
//         Console.WriteLine(n);
//     }
//     sum +=n;
// }
// Console.WriteLine("sum : " +sum);





