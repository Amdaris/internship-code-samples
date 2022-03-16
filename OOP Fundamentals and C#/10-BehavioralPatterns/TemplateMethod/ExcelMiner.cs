namespace TemplateMethod;

public class ExcelMiner : DataMiner
{
    protected override void OpenFile()
    {
        Console.WriteLine("Opening Excel file...");
    }

    protected override void ReadData()
    {
        Console.WriteLine("Reading data from Excel file");
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing data and extracting the needed information");
    }

    protected override void CloseFile()
    {
        Console.WriteLine("Closing Excel file...");
    }
}