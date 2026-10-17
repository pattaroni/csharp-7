using System;

public class Pupil
{
    public string Name { get; set; }

    public Pupil(string name)
    {
        Name = name;
    }

    public virtual void Study()
    {
        Console.WriteLine(Name + " вчиться.");
    }

    public virtual void Read()
    {
        Console.WriteLine(Name + " читає.");
    }

    public virtual void Write()
    {
        Console.WriteLine(Name + " пише.");
    }

    public virtual void Relax()
    {
        Console.WriteLine(Name + " відпочиває.");
    }
}
