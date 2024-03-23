
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();  


PrintAnyWord(userInput);
static void PrintAnyWord(string anyString)
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine(anyString);
    }
}