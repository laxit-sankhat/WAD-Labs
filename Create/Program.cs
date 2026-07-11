Random random = new Random();

int secretNumber = random.Next(1, 101);
int guess = 0;
int attempts = 0;

Console.WriteLine("Guess a number between 1 and 100:");

while (guess != secretNumber)
{
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess <= 0 || guess > 100 || !(guess is int))
    {
        Console.WriteLine("Invalid input!");
    }
    attempts++;

    if (guess < secretNumber)
    {
        Console.WriteLine("Too low");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high");
    }
    else
    {
        Console.WriteLine("Congratulations!");
        Console.WriteLine("Attempts: " + attempts);
    }
}