using System;

public class ExcelentPupil : Pupil
{
    public ExcelentPupil(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine(Name + " вчиться на відмінно і завжди виконує домашні завдання.");
    }

    public override void Read()
    {
        Console.WriteLine(Name + " читає швидко і переказує прочитане своїми словами.");
    }

    public override void Write()
    {
        Console.WriteLine(Name + " пише акуратно і без помилок.");
    }

    public override void Relax()
    {
        Console.WriteLine(Name + " відпочиває тільки після того, як зробить усі уроки.");
    }
}
