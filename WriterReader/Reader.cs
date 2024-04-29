namespace SewTestExeLast.WriterReader;

public class Reader
{
    static string ReadFromFile(string filePath)
    {
        void Read(string filename)
        {
            string[] namesList = File.ReadAllLines(filename);
            Names.AddRange(namesList);
        }
    }
}