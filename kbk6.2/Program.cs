// Богомолов Даниил 13 вариант базовый

Console.WriteLine("Введите текст: ");
string text = Console.ReadLine();
string[] words = text.Split(' ');

for (int index = 1; index < words.Length; index++)
{
    Console.Write(words[index]+ ' ');

}    