// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");
Thread.Sleep(1500);
Console.WriteLine("What is your name?");
String name = Console.ReadLine();
Thread.Sleep(1500);
Console.WriteLine("Hello, " + name);
Thread.Sleep(1500);
Console.WriteLine("Would you like to know when you turn 100?");
String awnser = Console.ReadLine();
if (awnser == "Yes")
{
    Thread.Sleep(1500);
    Console.WriteLine("What year were you born?");
    int year = Convert.ToInt32(Console.ReadLine());
    int newyear = year + 100;
    Thread.Sleep(1500);
    Console.WriteLine(name + " you will be 100 in the year " + newyear);
    Thread.Sleep(1500);
}
else
{
    Thread.Sleep(1500);
    Console.WriteLine("Okay then..");
}

Console.WriteLine("Would you want to do a test " + name + "?");
string awnser2 = Console.ReadLine();

if (awnser2 == "Yes")
{
    Thread.Sleep(1500);
    Console.WriteLine("Lets do some math then!");
    Console.WriteLine("9x + 8 = 16");
    Console.WriteLine("Solve for x");
    int awnser3 = Convert.ToInt32(Console.ReadLine());
    if (awnser3 == 3)
    {
        Thread.Sleep(1500);
        Console.WriteLine("Correct, " + name + "!");
    }
    else
    {
        Console.WriteLine("Sorry, " + name +" you got it wrong!");
        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xvFZjo5PgG0");
    }
    
}
else
{
    Thread.Sleep(1500);
    Console.WriteLine("Okay then..");
}
