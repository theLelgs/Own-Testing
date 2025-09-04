static void Start()
{
    Print("Where do you wish to go? \n1. Shack\n2. Cave\n3. Path", 1500);
    if (Keytest() == "1")
    {
        Kitchen();
    }
}
static void Intro()
{
    Print("You find yourself in an open field, seeing mostly trees and the rare boulder. ", 2500);
    Print("You see three points of interest. To the west there is a small shack next to a small lake. ", 3500);
    Print("To the east there is a cave in a mountain, and to the north there is a gravel path", 2500);
    Start();
}
static void Kitchen()
{
    
    Print("You walk inside the shack and find yourself inside a kitchen. What do you do?", 1500);
    Print("1. Check the cabinets\n2. Investigate other rooms\n3. Go back", 1000);
    string key = Keytest();
    if (key == "1")
    {
        Print("You look around the cabinets. Inside one of them, there is a knife rack, with a weirdly glowing knife. You pick it up incase it becomes useful later.", 4000);
        // bool knife = true;
        Kitchen();
    }
    else if (key == "2")
    {

    }
    else if (key == "3")
    {
        Start();
    }
}
static string Keytest()
{
    string a="0";
    while (a == "0")
    {
        if (Console.KeyAvailable)
        {
            a = Console.ReadKey().KeyChar.ToString();
        }
    }
    return a;
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
Intro();