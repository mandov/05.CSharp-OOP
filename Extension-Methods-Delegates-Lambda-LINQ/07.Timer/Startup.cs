using System;
using MethodTimer;

class Startup
{
    public static void Main()
    {

        Timer timer = new Timer(GiveThisNum, 1);
        timer.GetStarted();
    }

    public static int GiveThisNum()
    {
        return DateTime.Now.Second;
    }
}