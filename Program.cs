
#region Q1
//Q1: What will this print and explain what happens?

double d = 9.99;
int x = (int)d;
Console.WriteLine(x);
/*
this code will print "9" becuse when converting double to int ,the descimal wiill be removed and only the number before the dcimal point will be kept
*/
#endregion
#region Q2
//Q2: This code doesn’t compile. Fix it with the smallest change?
int n = 5;
double d2 =(double) n / 2;
Console.WriteLine(d2);
/*
this code will print "2" because n / 2 is an integer division, resulting in 2. To get the correct result as a double, you can cast n to double: double d2 = (double)n / 2;
*/
#endregion