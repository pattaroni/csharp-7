using System;

public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(Pupil[] pupils)
    {
        this.pupils = pupils;
    }

    public void StartLesson()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}
