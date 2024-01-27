using DesafioPOO.Models;

Iphone iphone = new Iphone("11 99959-0157", "Iphone 14", "123456789012345", 128);
Console.WriteLine(iphone.Numero);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
iphone.Numero = "11 999633-58475";
Console.WriteLine($"Trocando de número para: {iphone.Numero}");

Console.WriteLine("\n--------------------------------------------------------------\n");

Nokia nokia = new Nokia("11 95638-2157", "Nokia 3310", "123698756321498", 4);
Console.WriteLine(nokia.Numero);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
nokia.Numero = "11 99912-1313";
Console.WriteLine($"Trocando de número para: {nokia.Numero}");