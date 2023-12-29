using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone **IMPLEMENTADO*

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "99999", modelo: "Nokia 3310", imei: "5555555", memoria : 3 );
nokia.Exibir();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("------------------------------------------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "123456", modelo: "Iphone 14", imei: "1212121212", memoria : 256 );
iphone.Exibir();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsapp");

// Todos os testes realizados com sucesso