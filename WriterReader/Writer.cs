namespace SewTestExeLast.WriterReader;

public class Writer
{
    static void WriteToFile(string filePath, string content)
    {
            //Normal ohne Pfad 
            StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine(content);
            
            //bei gegebener datei
            string dateiPfad = "testDatei.txt";
            StreamWriter writer2 = new StreamWriter(filePath);
            writer2.WriteLine("Test");
    }
    
    public void SaveList(string filename)
    {
        File.WriteAllLines(filename,Names.ToArray());
    }

    static void Entry()
    {
        string filePath = "example.txt";
        string content = "Dies ist ein Testinhalt für eine Datei.";

        WriteToFile(filePath, content); // Schreiben in die Datei
        Console.WriteLine($"Inhalt wurde in '{filePath}' geschrieben.");
    }
}

