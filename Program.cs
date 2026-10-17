using System;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3And4();
    }

    // завдання 1
    static void Task1()
    {
        Console.WriteLine("Завдання 1");

        Pupil[] pupils = new Pupil[4];
        pupils[0] = new ExcelentPupil("Олексій");
        pupils[1] = new GoodPupil("Марія");
        pupils[2] = new BadPupil("Андрій");
        pupils[3] = new Pupil("Ірина");

        ClassRoom classRoom = new ClassRoom(pupils);
        classRoom.StartLesson();
    }

    // завдання 2
    static void Task2()
    {
        Console.WriteLine("Завдання 2");

        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Plane(100, 250, 50000000, 900, 2015, 10000, 180);
        vehicles[1] = new Car(10, 20, 750000, 180, 2021);
        vehicles[2] = new Ship(55, 80, 12000000, 40, 2010, 500, "Одеса");

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.PrintInfo();
        }

        Console.WriteLine();
    }

    // завдання 3 і 4
    static void Task3And4()
    {
        Console.WriteLine("Завдання 3 і 4");
        Console.Write("Введіть ключ доступу (pro або exp) або натисніть Enter: ");
        string key = Console.ReadLine() ?? "";

        DocumentWorker worker;

        if (key == "pro")
        {
            worker = new ProDocumentWorker();
        }
        else if (key == "exp")
        {
            worker = new ExpertDocumentWorker();
        }
        else
        {
            worker = new DocumentWorker();
        }

        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}
