// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please Enter your name: ");
string userName = Console.ReadLine();

Console.WriteLine("Hello, {0} the current time is {1}", userName, System.DateTime.Now.TimeOfDay);

Console.WriteLine("Press any key to quit.");
Console.ReadKey();

