
//Random Type
Random random = new Random();
Console.WriteLine(random.Next());
Console.WriteLine(random.Next(6));
Console.WriteLine($"Rolling a six- sided die: {random.Next(6) + 1}");
Console.WriteLine(random.Next(18, 22));
Console.WriteLine(random.NextDouble());
Console.WriteLine(random.NextDouble() * 10);
Console.WriteLine(random.NextDouble() * 20 - 10);
Random random2 = new Random(3445);
Console.WriteLine(random2.Next());

//Data type structure
DateTime time1 = new DateTime(2022, 12, 31);
DateTime time2 = new DateTime(2022, 12, 31, 23, 59, 55);
DateTime nowLocal = DateTime.Now;
DateTime nowUtc = DateTime.UtcNow;

DateTime time = DateTime.Now;
if (time.Month == 10)
{
    Console.WriteLine("Happy Halloween");

}
else if (time.Month == 4 && time.Day == 1)
{
    Console.WriteLine("April fools!):");
}
DateTime Tomorrow = DateTime.Now.AddDays(1);
// TimeSpan Struct
TimeSpan timeSpan1 = new TimeSpan(1, 30, 1);
TimeSpan timeSpan2 = new TimeSpan(2, 12, 0, 0);
TimeSpan timeSpan3 = new TimeSpan(0, 0, 0, 0, 500);
TimeSpan timeSpan4 = new TimeSpan(10);
TimeSpan aLittleWhile = TimeSpan.FromSeconds(3.5);
TimeSpan quiteAWhile = TimeSpan.FromHours(1.21);
TimeSpan timeLeft = new TimeSpan(1, 30, 0);
Console.WriteLine($"{timeLeft.Days}d {timeLeft.Hours}h {timeLeft.Minutes}m");
TimeSpan timeRemaining = new TimeSpan(1, 30, 0);
Console.WriteLine(timeRemaining.TotalHours);
Console.WriteLine(timeRemaining.TotalMinutes);
// the Guid 
Guid id = Guid.NewGuid();
// The list <T> Class
List<int> numbers1 = new List<int>();
List<int> numbers2 = new List<int>() { 1, 2, 3 };
List<int> numbers3 = new List<int> { 1, 2, 3 };
List<string> words1 = new List<string>() { "apple", "banana", "corn", "durian" };
Console.WriteLine(words1[2]);
words1[0] = "Avocado";
List<string> words2 = new List<string>();
words2.Add("apple");
List<string> words3 = new List<string>() { "apple", "banana", "durian" };
words3.Insert(2, "corn");
List<string> words4 = new List<string>();
words4.AddRange(new string[] { "apple", "durian" });
words4.InsertRange(1, new string[] { "banana", "corn" });
List<string> words5 = new List<string>() { "apple", "banana", "corn", "durian" };
words5.Remove("banana");
words5.RemoveAt(0);
words5.Clear();
Console.WriteLine(words5.Count);
bool hasApples = words5.Contains("apple");
if (hasApples)
{
    Console.WriteLine("Apples are already on the shopping list!");

}
int index = words5.IndexOf("apple");
public interface IEnumerable<T>
{
 IEnumerator<T> GetEnumerator();
}

public interface IEnumerator<T>
{
 T Current { get; }
 bool MoveNext();
 void Reset();
}
/*string text = "";
while (true)
{
 string? input = Console.ReadLine();
 if (input == null || input == "") break;
 text += input;
 text += ' ';
} 
Console.WriteLine(text);*/
