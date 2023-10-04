public class Programm
{
    public static TextReader reader = new StreamReader(Console.OpenStandardInput());
    public static TextWriter writer = new StreamWriter(Console.OpenStandardOutput());

    public static void Main(string[] args)
    {
        var a = ReadInteger();
        var b = ReadInteger();

        writer.WriteLine(a + b);

        reader.Close();
        writer.Close();
    }

    public static int ReadInteger()
    {
        if (int.TryParse(reader.ReadLine(), out var num))
        {
            return num;
        }
        else
        {
            writer.WriteLine("Введенный аргумент имеет неверный формат.");
            throw new ArgumentException("Введенный аргумент имеет неверный формат.");
        }
    }
}