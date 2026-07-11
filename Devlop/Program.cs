int[] subjects = new int[5];

Console.WriteLine("Enter marks of 5 subjects:");

int total = 0;

for (int i = 0; i < subjects.Length; i++)
{
    Console.Write("Enter marks of subject " + (i + 1) + ": ");
    subjects[i] = Convert.ToInt32(Console.ReadLine());

    if (subjects[i] < 0 || subjects[i] > 100)
    {
        Console.WriteLine("Invalid marks! Marks must be between 0 and 100.");
        return;
    }

    total += subjects[i];
}

float percentage = total / 5.0f;

string grade = percentage switch
{
    >= 90 => "A",
    >= 75 => "B",
    >= 50 => "C",
    _ => "FAIL"
};

Console.WriteLine("\nTotal Marks = " + total);
Console.WriteLine("Percentage = " + percentage + "%");
Console.WriteLine("Grade = " + grade);