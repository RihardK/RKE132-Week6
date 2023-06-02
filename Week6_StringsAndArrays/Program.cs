
string hello = "suspicious imposter.";
hello = hello.Trim();

int stringLength = hello.Length;

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

int wordCount = 1;

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordCount++;
    }
}

Console.WriteLine($"Word count in '{hello}' is : {wordCount} words");
