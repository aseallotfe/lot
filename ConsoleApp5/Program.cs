// See https://aka.ms/new-console-template for more information
using ConsoleApp5;
using System.ComponentModel.DataAnnotations;
Console.WriteLine("enter first name");
string x = Console.ReadLine();
Console.WriteLine("enter last name");
string y = Console.ReadLine();
Console.WriteLine("enter your email");
string v = Console.ReadLine();
person re = new person();
re.GetFullName(x, y);
re.Print(x, y, v);

