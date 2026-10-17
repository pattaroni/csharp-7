using System;

public class Car : Vehicle
{
    public Car(int x, int y, decimal price, int speed, int year)
        : base(x, y, price, speed, year)
    {
    }

    public override void PrintInfo()
    {
        Console.Write("Автомобіль. ");
        base.PrintInfo();
    }
}
