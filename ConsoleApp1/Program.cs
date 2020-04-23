using System;
using DpAutomation.Test;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DeliveryPerformanceAutomation dpAutomation=new DeliveryPerformanceAutomation();
            dpAutomation.LoginDelivereyPerformance();
        }
    }
}
