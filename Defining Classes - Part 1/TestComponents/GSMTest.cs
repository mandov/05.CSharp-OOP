

using System;
using GSM.Components;

public static class GSMTest
{
    public static void GSMShouldWork()
    {
        PhoneDevice[] phones =
        {
            new PhoneDevice("Galaxy A3","Samsung",650,"Bat Georgi",new Battery(BatteryType.LiIon,24,55),new Display(4.5,16000)),
            new PhoneDevice("iPhone 6s","Apple",1100,"Pesho",new Battery(BatteryType.NiMH,70,55),new Display(4.5,500000))
        };

        foreach (var phone in phones)
        {
            Console.WriteLine(phone);
        }

        Console.WriteLine(PhoneDevice.IPhone4S);
    }
}




