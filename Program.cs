Console.Title = "Alphabetical Character Indexer";

while (true)
{
    ConsoleKeyInfo cki = Console.ReadKey(true);

    if (cki.Key is ConsoleKey.Backspace or ConsoleKey.Enter)
    {
        Console.Clear();
        continue;
    }

    char c = cki.KeyChar;
    int ci = c switch
    {
        'a' => 1,
        'b' => 2,
        'c' => 3,
        'd' => 4,
        'e' => 5,
        'f' => 6,
        'g' => 7,
        'h' => 8,
        'i' => 9,
        'j' => 10,
        'k' => 11,
        'l' => 12,
        'm' => 13,
        'n' => 14,
        'o' => 15,
        'p' => 16,
        'q' => 17,
        'r' => 18,
        's' => 19,
        't' => 20,
        'u' => 21,
        'v' => 22,
        'w' => 23,
        'x' => 24,
        'y' => 25,
        'z' => 26,
        _ => -1,
    };

    if (ci == -1)
    {
        continue;
    }

    Console.Write(c);
    Console.Write(' ');
    Console.WriteLine(ci);
}