using System;

double numberPi = Math.PI;

Console.WriteLine($"PI: {numberPi}");

//Escape Characteres
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//Verbatim string literal
Console.WriteLine(@"   c:\source\repos   
      (this is where your code goes)");

//Unicode Escape
// Kon'nichiwa World
Console.WriteLine("\u3053 \u3093 \u306B \u3061 \u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

//String interpolation combined with verbatim
string projectNam = "First-Project";
Console.WriteLine($@"C:\Output\{projectNam}\Data");

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\t\tc:\\Exercise\\{projectName}\\data.txt\n");
Console.WriteLine(russianMessage + ":\n\t\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt\n");