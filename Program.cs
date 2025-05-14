using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("16 0000-0000", "16Pro", "0000000-0", 256);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Smartphone nokia = new Nokia("18 0000-0000", "Tijolão", "1111111-1", 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");