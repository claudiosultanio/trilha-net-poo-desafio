using System.ComponentModel;
using DesafioPOO.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
 Smartphone nokia = new Nokia(numero:"1910101010",modelo:"N22",imei:"9876543210",memoria:128);
 nokia.Ligar();
 nokia.InstalarAplicativo("maps");

 Console.WriteLine("\n");

 Console.WriteLine("Smartphone Iphone:");
 Smartphone iphone = new Iphone(numero:"1912341234",modelo:"14PRO",imei:"9876543210",memoria:128);
 iphone.Ligar();
 iphone.InstalarAplicativo("waze");




