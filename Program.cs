using DesafioPOO.Models;

// Testando a classe Nokia
Console.WriteLine("--- Smartphone Nokia ---");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Tijolão G2", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n--------------------------\n");

// Testando a classe Iphone
Console.WriteLine("--- Smartphone iPhone ---");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "iPhone 15 Pro", imei: "222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");