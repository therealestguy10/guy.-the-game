// See https://aka.ms/new-console-template for more information

// epic guy. appearance

Console.Title = "guy.exe";
Console.ForegroundColor = ConsoleColor.Green;

// epic guy. conversation

Console.WriteLine("this is a real guy. moment \n1. real\n2. fake");
string answer = (Console.ReadLine());
if (answer == "1")
{
    Console.WriteLine("Indubitably \n1. jk lmao\n2. realest of reals");
    string answer2 = (Console.ReadLine());
    if (answer2 == "1")
    {
        Console.WriteLine("fuck you");
    }
    else if (answer2 == "2")
    {
        Console.WriteLine("real \n1. ascend \n2. descend into madness");
        var answer3 = (Console.ReadLine());
        if (answer3 == "1")
        {
            Console.WriteLine("you are now apart of guy., how do you feel? \n1. good ig \n2. i hate it");
            var answer4 = (Console.ReadLine());
            if (answer4 == "1")
            {
                Console.WriteLine("nice \ngood ending uhhh");
            }
            else if (answer4 == "2")
            {
                Console.WriteLine("fuck you \nbad ending 2 uhhhhhhhh");
            }
            else
            {
                Console.WriteLine("what");
            }
        }
        else if (answer3 == "2")
        {
            Console.WriteLine("imagine going insane lmao \nbad ending 1 uhhhhh");
        }
        else
        {
            Console.WriteLine("what");
        }
    }
    else
    {
        Console.WriteLine("what");
    }
}
else if (answer == "2")
{
    Console.WriteLine("fuck you");
}
else
{
    Console.WriteLine("what");
}
Console.ReadKey();

