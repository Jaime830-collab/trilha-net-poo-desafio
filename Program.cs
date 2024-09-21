using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n = new Nokia("123", "Nokia", "123", 128);
Iphone i = new Iphone("456", "Iphone", "456", 256);

n.InstalarAplicativo("WhatsApp");
n.Ligar();
n.ReceberLigacao();

i.InstalarAplicativo("Instagram");
i.Ligar();
i.ReceberLigacao();