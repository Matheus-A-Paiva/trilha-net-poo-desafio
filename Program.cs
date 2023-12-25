using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "012345", modelo: "Modelo Y", imei: "111111111111111" , memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
nokia.Numero = "022345";
nokia.ExibirDataEHora();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "22445", modelo: "Modelo Z", imei: "222222222222222" , memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
iphone.ExibirDataEHora();
