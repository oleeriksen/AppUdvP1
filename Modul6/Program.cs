// See https://aka.ms/new-console-template for more information

using Modul6;

Console.WriteLine("Hello, modul6");
//DiceApp.Run();
//new PersonApp().Run();
DateTime d;
if (DateTime.TryParse($"1978-12-4", out d ))
   Console.WriteLine(d);
   else
   Console.WriteLine("invalid dato");