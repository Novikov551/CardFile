public class Programm
{
    public static TextReader reader = new StreamReader(Console.OpenStandardInput());
    public static TextWriter writer = new StreamWriter(Console.OpenStandardOutput());

    public static void Main(string[] args)
    {
        var n = int.Parse(reader.ReadLine());
        var resultStr = GetMovingAverage(reader.ReadLine(),
            int.Parse(reader.ReadLine()));

        writer.WriteLine(resultStr);

        reader.Close();
        writer.Close();
    }

    public static string GetMovingAverage(string arr,
        int k)
    {
        var counter = 0;
        var result = "";
        var nums = new List<int>();
        var strs = arr.Split(" ");

        for (var i = 0; i < strs.Length; i++)
        {
            if (counter < k)
            {
                nums.Add(int.Parse(strs[i]));
            }
            else if(counter >= k)
            {
                result += $"{(float)nums.Sum() / k} ";
                nums.Remove(nums[0]);
                nums.Add(int.Parse(strs[i]));
            }

            counter++;
        }

        return result += $"{(float)nums.Sum() / k} ";
    }
}