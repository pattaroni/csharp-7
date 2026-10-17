using System;

public class Vehicle
{
    public int X { get; set; }
    public int Y { get; set; }
    public decimal Price { get; set; }
    public int Speed { get; set; }
    public int Year { get; set; }

    public Vehicle(int x, int y, decimal price, int speed, int year)
    {
        X = x;
        Y = y;
        Price = price;
        Speed = speed;
        Year = year;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine("Координати: (" + X + "; " + Y + "), ціна: " + Price + " грн, швидкість: " + Speed + " км/год, рік випуску: " + Year);
    }
}
