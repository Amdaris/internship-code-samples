namespace TemplateMethod;

public abstract class DataMiner
{
    public void MineData()
    {
        Console.WriteLine("Data mining process has started....");
        OpenFile();
        ReadData();
        ParseData();
        AnalyzeData();
        SendReport();
        CloseFile();
        Console.WriteLine("Data mining process completed...");
    }

    protected abstract void OpenFile();
    protected abstract void ReadData();
    protected abstract void ParseData();

    protected void AnalyzeData()
    {
        Console.WriteLine("Analyzing data....");
    }

    protected void SendReport()
    {
        Console.WriteLine("Sending report....");
    }

    protected abstract void CloseFile();
}