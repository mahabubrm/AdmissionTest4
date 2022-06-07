using Task4;

string inputText = string.Empty;
FormatChecker fc = new FormatChecker();
Console.Write("Input the mobile no : ");
inputText = Console.ReadLine();
bool res = fc.IsValid(inputText);
Console.WriteLine(res);
Console.WriteLine();