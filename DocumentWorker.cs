using System;

public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Відкриття документа — доступно у безкоштовній версії.");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редагування документа недоступне у безкоштовній версії.");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Збереження документа недоступне у безкоштовній версії.");
    }
}
