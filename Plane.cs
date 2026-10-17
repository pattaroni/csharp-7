using System;

public class Plane : Vehicle
{
    public int Height { get; set; }
    public int PassengersCount { get; set; }

    public Plane(int x, int y, decimal price, int speed, int year, int height, int passengersCount)
        : base(x, y, price, speed, year)
    {
        Height = height;
        PassengersCount = passengersCount;
    }

    public override void PrintInfo()
    {
        Console.Write("Літак. ");
        base.PrintInfo();
        Console.WriteLine("   Висота польоту: " + Height + " м, пасажирів: " + PassengersCount);
    }
}
