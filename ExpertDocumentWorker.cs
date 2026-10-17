using System;

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Розширене редагування документа — доступно у Expert-версії.");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Збереження документа у будь-якому форматі — доступно у Expert-версії.");
    }
}
