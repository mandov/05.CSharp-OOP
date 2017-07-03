using System;
using GSM.Components;
using System.Collections.Generic;

public static class CallHistoryTest
{
    public static void CallHistoryTestShouldWork() {

        PhoneDevice gsm = new PhoneDevice("Lumia", "Nokia", 600, "Ivan", new Battery(BatteryType.LiIon, 120, 44), new Display(4.7, 160000));
        List<Call> calls = new List<Call>();
        Call firstCall = new Call(new DateTime(2017, 6, 24), "16:45", 45);
        Call secondCall = new Call(new DateTime(2017, 6, 24), "18:22", 150);
        calls.Add(firstCall);
        calls.Add(secondCall);
        gsm.CallHistory = calls;

        Console.WriteLine();
        Console.WriteLine(gsm.ReturnAllCallHistory());
        Console.WriteLine("Total price for all calls:{0}", gsm.CalculateTotalPrice());
        gsm.RemoveLongestCall();
        Console.WriteLine("Total price for all calls after remove longest:{0}",gsm.CalculateTotalPrice());
      }
}