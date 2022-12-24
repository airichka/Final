Console.Write("Введите через запитую элементы массива: ");
var userInput = Console.ReadLine();

var words = ParseWords(userInput);
var wordsWhith3Chars = GetWordsWith3Chars(words);

foreach (var word in wordsWhith3Chars)
{
	Console.WriteLine(word);
}

IEnumerable<string> ParseWords(string userInput)
{
	return userInput.Replace(" ", string.Empty).Split(',');
}

IEnumerable<string> GetWordsWith3Chars(IEnumerable<string> strings)
{
	return strings.Where(x => x.Length <= 3);
}