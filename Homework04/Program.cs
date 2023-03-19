//Task 1
Console.WriteLine("====Task01====");

string stringFiveCharacters = "123456789";
stringFiveCharacters = stringFiveCharacters.Substring(stringFiveCharacters.Length - 5);
Console.WriteLine(stringFiveCharacters);

//Task 2
Console.WriteLine("====Task02====");

Console.WriteLine("Take a sentence");
string text = Console.ReadLine();

string[] sentence = text.Split(" ");

foreach (var words in sentence)
{
    var word = removeChars(words);
    Console.WriteLine(word);
}
string removeChars(string words)
{
    var word = words;

    if (word.StartsWith("\""))
    {
        word = word.Remove(0, 1);
    }

    return word;
}

//Task03
Console.WriteLine("====Task03====");
int AddNumbers(int num1, int num2)
{
    int result = num1 + num2;
    return result;
}
int result = AddNumbers(21, 11);
Console.WriteLine(result);

//Bonus
Console.WriteLine("====Bonus====");

string largest = "";
string input = Console.ReadLine();

string[] array = input.Split(' ');

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length > largest.Length)
        largest = array[i];
}
Console.WriteLine("Largest word is: " + largest);