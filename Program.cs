using DesafioPOO.Models;
using System;
using System.Linq;



Smartphone nokia = new Nokia("11999999999", "3310", "123456789012345", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Smartphone iphone = new Iphone("11988888888", "14 Pro", "987654321098765", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");