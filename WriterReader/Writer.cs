namespace SewTestExeLast.WriterReader;

public class Writer
{
    static void WriteToFile(string filePath, string content)
    {
        StreamWriter writer = null;
        try
        {
            // Erstellen oder Öffnen der Datei zum Schreiben
            writer = new StreamWriter(filePath);
            writer.WriteLine(content); // Schreiben einer Zeile in die Datei
        }
        finally
        {
            // Stellen Sie sicher, dass der StreamWriter geschlossen wird, selbst bei Fehlern
            if (writer != null)
            {
                writer.Close(); // Schließen der Datei
            }
        }
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

