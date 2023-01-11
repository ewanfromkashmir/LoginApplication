class Program
{
    static void Main()
    {
        string? username = "";
        string? password = "";
        int attempts = 3;
        var program = new Program();

        while (attempts >= 0)
        {
            do
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine();
            }
            while (!(username != "" && program.Check(username) && username != null));

            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            }
            while (!(password != "" && program.Check(password) && password != null));

            if (username.ToLower() == "admin" && password == "password1")
            {
                Console.Write("Access granted. Welcome.");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.Write("Access denied. " + attempts + " attempts remaining.");
                Console.WriteLine();
                attempts--;

            }


        }

        Console.Write("System locked. Please contact an administrator.");
        Console.WriteLine();
        return;

    }

    public bool Check(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] < 48 || (text[i] < 65 && text[i] > 57) || text[i] > 122 || (text[i] < 97 && text[i] > 90))
            {
                return false;
            }
        }

        return true;
    }
    
}