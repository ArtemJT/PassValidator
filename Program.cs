try
{
    StreamReader reader = new("passwords.txt");
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        if (line.Equals(""))
        {
            continue;
        }

        string[] strings = splitString(line);
        char? symb = char.Parse(strings[0]);

        int[]? counts = splitCounters(strings[1]);

        string? pass = strings[2];

        if (symb != null & counts != null & pass != null)
        {
            int counter = 0;
            int min = counts[0];
            int max = counts[1];

            char[] passChars = pass.ToCharArray();
            for (int i = 0; i < passChars.Length; i++)
            {
                if (passChars[i].Equals(symb)) 
                {
                    counter++;        
                }
            }

            if (counter < min || counter > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password: '" + pass + "' isn't valid with symbol: '" + symb + "'");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Password: '" + pass + "' is valid with symbol: '" + symb + "'");
            }
        }
    }
    reader.Close();
}
catch (IOException e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
}

static string[] splitString(string s)
{
    return s.Split(separator: " ");
}

static int[]? splitCounters(string s)
{
    string[] strings = s.Replace(":","").Split(separator: "-");
    try
    {
        int min = int.Parse(strings[0]);
        int max = int.Parse(strings[1]);
        return new int[] { min, max };
    } catch (FormatException e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(e.Message);
    } 
    return null;
}

