List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine("List Elements:\n");

foreach(int num in numberList)
{
    Console.WriteLine(num);
}

Dictionary<int, string> number_dictionary = new Dictionary<int, string>
{
    { 1, "One" },
    { 2, "Two" },
    { 3, "Three" },
    { 4, "Four" },
    { 5, "Five" }
};

Console.WriteLine("Dictionary Elements:\n");

foreach(KeyValuePair<int,string> item in number_dictionary)
{
    Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
}

Stack<int> numberStack = new Stack<int>();

numberStack.Push(1);
numberStack.Push(2);
numberStack.Push(3);
numberStack.Push(4);
numberStack.Push(5);

Console.WriteLine("\nStack Elements:\n");

foreach (int num in numberStack)
{
    Console.WriteLine(num);
}

Console.WriteLine("\ntop element of the stack: " + numberStack.Peek() + "\n");

Queue<int> numberQueue = new Queue<int>();

numberQueue.Enqueue(1);
numberQueue.Enqueue(2);
numberQueue.Enqueue(3);
numberQueue.Enqueue(4);
numberQueue.Enqueue(5);

Console.WriteLine("\nQueue Elements:\n");

foreach (int num in numberQueue)
{
    Console.WriteLine(num);
}

Console.WriteLine("\nfront element of the queue: " + numberQueue.Peek() + "\n");


