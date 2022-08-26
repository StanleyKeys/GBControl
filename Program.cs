


Console.Clear();
Console.Write("Input your text: ");

string userEnter = Console.ReadLine();

string[] subs = userEnter.Split();

Console.WriteLine($"\nв строке слова, у которых меньше 3 символов: ");

for (int i = 0; i < subs.Length; i++)
{
    string temp = subs[i];
        if (temp.Length <= 3)
    {
        Console.Write(temp + " ");
    }
}

