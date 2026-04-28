
#region Q1
//Q1: What will this print and explain what happens?

using System.Numerics;
using System.Xml.Linq;

//double d = 9.99;
//int x = (int)d;
//Console.WriteLine(x);
/*
this code will print "9" becuse when converting double to int ,the descimal wiill be removed and only the number before the dcimal point will be kept
*/
#endregion
#region Q2
//Q2: This code doesn’t compile. Fix it with the smallest change?
//int n = 5;
//double d2 =(double) n / 2;
//Console.WriteLine(d2);
/*
this code will print "2" because n / 2 is an integer division, resulting in 2. To get the correct result as a double, you can cast n to double: double d2 = (double)n / 2;
*/
#endregion
#region Q3
/*Q3: You read a number from user input .. Write the correct line to
get age as int.
*/
//Console.WriteLine("Enter your age:");
//int age =int.Parse(Console.ReadLine());
// This code will read a line of input from the user, parse it as an integer, and store it in the variable 'age'. If the user enters a valid integer, it will be assigned to 'age'.
//If the input is not a valid integer, it will throw a FormatException.
#endregion
#region Q4
//Q4: What happens here and why?
/*string s = "12a";
int x = int.Parse(s);
Console.WriteLine(x);
*/
//this code will not be run because the string cannot be converted or cast to an integer
#endregion
#region Q5
//Q5: Complete the code from the previous question so it prints
//Invalid if conversion into int fails, otherwise prints the number
/*string s = "12a";
if (int.TryParse(s, out x))

    Console.WriteLine(x);
else
Console.WriteLine("Invalid input");
*/
#endregion
#region Q6
//Q6: What will this print and explain why ?
//object o = 10;
//int a = (int)o;
//Console.WriteLine(a + 1);
// This code will print "11" because the object 'o' is assigned the value 10, which is an integer. When we cast 'o' to an integer and assign it to 'a', 
//it successfully converts the value to 10. Then, when we add 1 to 'a', it results in 11, which is printed to the console.
#endregion
#region Q7
//Q7: What will this print and explain why and if there is a
//problem handle it ?
//object o = 10;
//long x = (long)(int)o;
//Console.WriteLine(x);
// This code will throw an InvalidCastException at runtime because you cannot directly cast an object that contains an integer (10) to a long type.
#endregion
#region Q8
//Q8: Fix this to avoid exceptions and print -1 if conversion isn’t
//possible?
//object o = 10;
//int? temp = o as int?;
//long x = temp ?? -1; 

//Console.WriteLine(x);
#endregion
#region Q9
//Q9: What will this print and explain why ?

//string? name = null;
//Console.WriteLine(name?.Length);
//this code will print an empety line becuse it allow null values and there is nothing to calculate the lenth;
#endregion
#region Q10
//Q10: What will this print and explain the process?

string? name2 = null;
int length = name2?.Length ?? 0;
//this code will print 0 , becuse the null conditional operator is check if name2 is null ,and Null-Coalescing Operator is check if the result of name2?.Length is null,
//if it is null it will return 0,herwise it will return the length of the string. In this case, since name2 is null, the length variable will be assigned the value 0.
#endregion