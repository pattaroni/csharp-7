using System;

public class Ship : Vehicle
{
    public int PassengersCount { get; set; }
    public string HomePort { get; set; }

    public Ship(int x, int y, decimal price, int speed, int year, int passengersCount, string homePort)
        : base(x, y, price, speed, year)
    {
        PassengersCount = passengersCount;
        HomePort = homePort;
    }

    public override void PrintInfo()
    {
        Console.Write("Корабель. ");
        base.PrintInfo();
        Console.WriteLine("   Пасажирів: " + PassengersCount + ", порт приписки: " + HomePort);
    }
}
