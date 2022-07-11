namespace TemplateMethod;

public class PDFMiner : DataMiner
{
    protected override void OpenFile()
    {
        Console.WriteLine("Opening PDF file...");
    }

    protected override void ReadData()
    {
        Console.WriteLine("Reading data from PDF file");
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing data and extracting the needed information");
    }

    protected override void CloseFile()
    {
        Console.WriteLine("Closing PDF file...");
    }
}