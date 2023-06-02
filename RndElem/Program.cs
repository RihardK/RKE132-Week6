
string[] snacks = {"sushi", "pizza", "burger", "kebab", "asian" };

Random rnd = new Random();

int rndIndex = rnd.Next(0, snacks.Length + 1);

Console.WriteLine($"The food will be: {snacks[rndIndex]}");