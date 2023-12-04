﻿using System.ComponentModel;
using DesafioPOO.Models;



Console.WriteLine("Smatphont Nokia:");
Smartphone nokia = new Nokia (numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222222222222", memoria: 128);
iphone.InstalarAplicativo("Telegram"); 