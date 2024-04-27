namespace SewTestExeLast.WriterReader;

public class Reader
{
    static string ReadFromFile(string filePath)
    {
        StreamReader reader = null;
        try
        {
            // Öffnen der Datei zum Lesen
            reader = new StreamReader(filePath);
            return reader.ReadToEnd(); // Lesen des gesamten Inhalts der Datei
        }
        finally
        {
            // Stellen Sie sicher, dass der StreamReader geschlossen wird, selbst bei Fehlern
            if (reader != null)
            {
                reader.Close(); // Schließen der Datei
            }
        }
    }
    public void Read(string filename)
    { 
        string[] namesList = File.ReadAllLines(filename);
        Names.AddRange(namesList);
    }
}