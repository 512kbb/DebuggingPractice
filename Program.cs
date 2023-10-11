namespace DebuggingPractice;
class Program
{
    static void Main(string[] args)
    {
        // Challenge 1
        bool amProgrammer = true;
        double Age = 27.9;
        List<string> Names = new List<string>();
        Names.Add("Monica");
        Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
        MyDictionary.Add("Hello", "0");
        MyDictionary.Add("Hi there", "0");
        Console.WriteLine("-------------------");
        // Challenge 2
        List<int> Numbers = new List<int>() { 2, 3, 6, 7, 1, 5 };
        for (int i = Numbers.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(Numbers[i]);
        }
        Console.WriteLine("-------------------");
        // Challenge 3
        List<int> MoreNumbers = new List<int>() { 12, 7, 10, -3, 9 };
        foreach (int number in MoreNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("-------------------");
        // Challenge 4
        List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
        foreach (int num in new List<int>(EvenMoreNumbers))
        {
            if (num % 3 == 0)
            {
                int index = EvenMoreNumbers.IndexOf(num);
                if (index != -1)
                {
                    EvenMoreNumbers[index] = 0;
                }

            }
        }
        Console.WriteLine("-------------------");
        foreach (int num in EvenMoreNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("-------------------");

        // Challenge 5
        // What can we learn from this error message?
        // string are inmutable
        string MyString = "superduberawesome";
        // MyString[7] = "p"; 
        string newString = MyString.Replace("b", "p");
        Console.WriteLine(newString);

        Console.WriteLine("-------------------");
        // Challenge 6
        // Hint: some bugs don't come with error messages
        Random rand = new Random();
        int randomNum = rand.Next(13);
        Console.WriteLine(randomNum);
        if (randomNum == 12)
        {
            Console.WriteLine("Hello");
        }

    }
}
