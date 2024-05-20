using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Iphone iPhone = new Iphone( numero: "11-9999-9999", modelo: "IPhone 11", imei: "Apple-1234-iPhone-11", memoria:64);

Console.WriteLine("IPhone");
Console.WriteLine("======================");
Console.WriteLine("SmartPhone Iphone");
Console.WriteLine("Número : " + iPhone.Numero);
Console.WriteLine("Modelo : " + iPhone.Modelo);
Console.WriteLine("iMei...: " + iPhone.Imei);
Console.WriteLine("Memória: " + iPhone.Memoria);

iPhone.InstalarAplicativo("WhatsApp");



Nokia nokia = new Nokia( numero: "11-9999-9999", modelo: "N95", imei: "Nokia-1234-Nokia-n95", memoria:64);

Console.WriteLine("Nokia");
Console.WriteLine("======================");
Console.WriteLine("SmartPhone Nokia");
Console.WriteLine("Número : " + nokia.Numero);
Console.WriteLine("Modelo : " + nokia.Modelo);
Console.WriteLine("iMei...: " + nokia.Imei);
Console.WriteLine("Memória: " + nokia.Memoria);

iPhone.InstalarAplicativo("WhatsApp");

