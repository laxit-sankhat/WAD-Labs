Console.WriteLine("Enter a sentence: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split(' ');

Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

foreach(string word in words)
{
    string currentWord = word.ToLower();
    if (wordFrequency.ContainsKey(currentWord))
    {
        wordFrequency[currentWord]++;
    }
    else
    {
        wordFrequency[currentWord] = 1;
    }
}

Console.WriteLine("\nWord Frequency:");

foreach (KeyValuePair<string, int> item in wordFrequency)
{
    Console.WriteLine("Word: " + item.Key + ", Frequency: " + item.Value);
}

