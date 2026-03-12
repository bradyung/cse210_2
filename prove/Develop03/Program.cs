using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Bob");
        Console.WriteLine(myWord.GetWordString());
        myWord.HideWord();
        Console.WriteLine(myWord.GetWordString());

        Word myWord2 = new Word("Moroni");
        Console.WriteLine(myWord2.GetWordString());
        myWord2.HideWord();
        Console.WriteLine(myWord2.GetWordString());
    }
}