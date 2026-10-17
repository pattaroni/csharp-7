using System;

public class GoodPupil : Pupil
{
    public GoodPupil(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine(Name + " вчиться добре, але інколи припускається помилок.");
    }

    public override void Read()
    {
        Console.WriteLine(Name + " читає уважно, хоча не завжди встигає дочитати до кінця.");
    }

    public override void Write()
    {
        Console.WriteLine(Name + " пише охайно, трапляються дрібні помилки.");
    }

    public override void Relax()
    {
        Console.WriteLine(Name + " відпочиває у перервах між уроками.");
    }
}
