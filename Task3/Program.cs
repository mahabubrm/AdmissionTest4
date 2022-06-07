
using Task3;

string inputText = string.Empty;
FileUtility wc = new FileUtility();
Console.Write("Input the string : ");
inputText = Console.ReadLine();
wc.WriteLine(inputText);
Console.WriteLine("Success");
Console.WriteLine();