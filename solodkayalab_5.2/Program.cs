string inputString = Console.ReadLine();
string a = "";

for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i] == '!')
    {
        a += i.ToString();
    }
    else
    {
        a += inputString[i];
    }
}

Console.WriteLine(a);