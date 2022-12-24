Console.Write("Введите через запитую элементы массива: ");
var userInput = Console.ReadLine();

var words = ParseWords(userInput);


IEnumerable<string> ParseWords(string userInput)
{
	return userInput.Replace(" ", string.Empty).Split(',');
}