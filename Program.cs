using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "995218026", modelo: "Modelo 1", imei: "11111111", memoria: 65);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "998308900", modelo: "Modelo X", imei: "22222222", memoria: 265);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Subway Surf");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Android:");
Smartphone android = new Android(numero: "998354900", modelo: "Modelo S22", imei: "33333333", memoria: 120);
android.Ligar();
android.ReceberLigacao();
android.InstalarAplicativo("Red Dead 2 Emulador");