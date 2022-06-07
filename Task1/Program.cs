using Task1;

string inputText = string.Empty;
WordCounter wc = new WordCounter();
Console.Write("Input the string : ");
inputText = Console.ReadLine();
int res = wc.Count(inputText);
Console.WriteLine(res);
Console.WriteLine();
