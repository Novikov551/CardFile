public class Programm
{
    public static TextReader reader = new StreamReader(Console.OpenStandardInput());
    public static TextWriter writer = new StreamWriter(Console.OpenStandardOutput());

    public static void Main(string[] args)
    {
        var arrsLenght = ReadInteger();
        var firstArr = ReadArr(arrsLenght);
        var secondArr = ReadArr(arrsLenght);

        var result = GetZipperCloseArr(firstArr, secondArr);
        var resultStr = "";
        foreach (var item in result)
        {
            resultStr += item + " ";
        }

        writer.WriteLine(resultStr);

        reader.Close();
        writer.Close();
    }

    public static int[] GetZipperCloseArr(int[] first, int[] second)
    {
        var resultArrLenght = first.Length + second.Length;
        var resultArr = new int[resultArrLenght];
        var resArrCounter = 0;

        for (int i = 0; i < resultArrLenght / 2; i++)
        {
            resultArr[resArrCounter] = first[i];
            resArrCounter++;
            resultArr[resArrCounter] = second[i];
            resArrCounter++;
        }

        return resultArr;
    }

    public static int[] ReadArr(int arrLenght)
    {
        var arr = new int[arrLenght];
        var strNums = reader.ReadLine().Split(" ");

        if (strNums.Length != arrLenght)
        {
            writer.WriteLine("Длинна введенного  массива не совпадает с заданной изначально.");
            throw new ArgumentOutOfRangeException("Длинна введенного  массива не совпадает с заданной изначально.");
        }

        for (int i = 0; i < arrLenght; i++)
        {
            if (int.TryParse(strNums[i], out var num))
            {
                arr[i] = num;
            }
            else
            {
                writer.WriteLine("Введенный аргумент имеет неверный формат.");
                throw new ArgumentException("Введенный аргумент имеет неверный формат.");
            }
        }

        return arr;
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