using System;

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Редагування документа — доступно у Pro-версії.");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Збереження документа — доступно у Pro-версії.");
    }
}
