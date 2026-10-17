using System;

public class BadPupil : Pupil
{
    public BadPupil(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine(Name + " вчиться погано і часто не слухає на уроці.");
    }

    public override void Read()
    {
        Console.WriteLine(Name + " читає повільно і плутає слова.");
    }

    public override void Write()
    {
        Console.WriteLine(Name + " пише з великою кількістю помилок.");
    }

    public override void Relax()
    {
        Console.WriteLine(Name + " відпочиває замість того, щоб робити уроки.");
    }
}
