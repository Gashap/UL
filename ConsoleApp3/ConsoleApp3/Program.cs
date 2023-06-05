internal class Program
{
	public static void Main(string[] args)
	{
		Lq1();
		Lq2();
		Lq3();
	}

	private static void Lq1()
	{
		var array = new[] { 1, 2, 3, 4, 5 };
        foreach (var t in array) Console.Write(t+ " ");
        
        Console.WriteLine();
        const int k = 2;
        array = array.Skip(k).Concat(array.Take(k)).ToArray();
        foreach (var t in array) Console.Write(t+ " ");
	}

	private static void Lq2()
	{
		var points = new List<(int, int)> { (0, 0), (0, 0) };
		var result = new HashSet<(int, int)>();

		foreach (var point in points)
			for (var i = -1; i <= 1; i++)
				for (var j = -1; j <= 1; j++)
				{
					if (i == 0 && j == 0) continue;
					result.Add((point.Item1 + i, point.Item2 + j));
				}

		foreach (var point in result) Console.WriteLine(point);
	}

	private static void Lq3()
	{
		var words = new[] { "hello", "world", "banana", "профессия", "искусство", "длинношеее" };
		var result = new List<string>();

		foreach (var word in words)
		{
			var charCounts = new Dictionary<char, int>();
			var isValid = true;
			
			foreach (var c in word)
			{
				charCounts.TryAdd(c, 0);
				charCounts[c]++;
				if (charCounts[c] <= 2) continue;
				isValid = false;
				break;
			}
			if (isValid) result.Add(word);
		}
		foreach (var word in result) Console.WriteLine(word);
	}
}