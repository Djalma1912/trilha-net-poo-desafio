using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Modelo Nokia", "12345", 64);
nokia.Ligar();
nokia.InstalarAplicativo("\"WhatsApp\"");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("987654321", "Modelo iPhone", "67890", "memoria", "128GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("\"Instagram\"");