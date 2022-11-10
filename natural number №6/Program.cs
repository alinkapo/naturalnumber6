namespace natural_number__6
{
  internal class Program
  {
     static void Main(string[] args)
     {
      Console.WriteLine("Введите список чисел:");
      var N = Convert.ToInt32(Console.ReadLine());
      var t = Array.ConvertAll(Console.ReadLine().Split(' '), f => int.Parse(f));
      var result = 0;
     for (int i = 1; i < N-1; i++)
     {
     result += t[i-1] < t[i] && t[i+1] < t[i] ? 1:0;
     }
     Console.WriteLine("Полученный результат:");
     Console.WriteLine(result);
     }
  }
}
