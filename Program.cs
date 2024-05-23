using DesafioPOO.Models;

Nokia nokia= new Nokia("99999-9999", "Nokia1", "IMEI1111222", 256);

nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();


Iphone iphone= new Iphone("98888-8888", "Iphone15", "IMEI33334444", 512);

iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();