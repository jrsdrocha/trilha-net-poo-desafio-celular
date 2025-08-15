using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Smartphone celular = new Smartphone(); Tentativa de instaciar a classe Smartphone. Como previsto, foi dado um erro pois, classes abstratas nao podem ser instanciadas.

Nokia nokia_1100 = new Nokia("(32)3536-4566", "nokia-1100", "11223344", 16);
Console.WriteLine($"{nokia_1100.Numero}");
nokia_1100.Ligar();
nokia_1100.ReceberLigacao();
nokia_1100.InstalarAplicativo("FaceBook");

Console.WriteLine($"--------------------------------------------------------------");


Iphone iphone_22 = new Iphone("(011) 9875-7414", "Iphone 22", "99887744", 32);
Console.WriteLine($"{iphone_22.Numero}");
iphone_22.InstalarAplicativo("Instagram");
iphone_22.ReceberLigacao();
iphone_22.Ligar();



