// while (true)
// {
//     if (Console.KeyAvailable == true)
//     {
//         ConsoleKey key = Console.ReadKey().Key;
//         Console.WriteLine(key);
//     }
// }
static void Start()
{
    Print("Where do you wish to go? \n1. Shack\n2. Cave\n3. Path", 1500);
    
}
static void Intro()
{
    Print("You find yourself in an open field, seeing mostly trees and the rare boulder. ", 2500);
    Print("You see three points of interest. To the west there is a small shack next to a small lake. ", 3500);
    Print("To the east there is a cave in a mountain, and to the north there is a gravel path", 2500);
}
static void Kitchen()
{
    Print("You walk inside the shack and find yourself inside a kitchen. What do you do?", 1500);
    Print("1. Check the cabinets\n2. Investigate other rooms", 1000);
}


static void Print(string a, int time)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i]);
        Thread.Sleep(time / a.Length);
        if (Console.KeyAvailable == true)
        {
            if (Console.ReadKey().KeyChar == ' ')
            {
                time = 0;
            }
        }

    }
    Console.Write("\n");
}
// List<ConsoleKey>
// delegate ConsoleKey KeyTest(string x);

var key=0;
Intro();
Start();
while (key != '1' && key != '2' && key != '3')
{
    if (Console.KeyAvailable == true)
    {
        key = Console.ReadKey().KeyChar;
    }
}
if (key == '1')
{
    Kitchen();
}
