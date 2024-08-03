// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = string.Empty;
int age = 0;
double salary = 0;
char gender = char.MinValue;
bool working;

Console.WriteLine("Enter Your Name! ");
name =  Console.ReadLine();
Console.WriteLine("Enter your Age: ");
age = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Enter your salary: ");
salary = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Enter your Gender: ");
gender =Convert.ToChar( Console.ReadLine());
Console.WriteLine("Are you Working? ");
working = Convert.ToBoolean( Console.ReadLine());


//Print all details
Console.WriteLine("Your name is: " + name);
Console.WriteLine("Your age is: {0} " , age);
Console.WriteLine("Your Salary is: " + salary);
Console.WriteLine("Your Gender is: " + gender);
Console.WriteLine("Your Working status: " + working);