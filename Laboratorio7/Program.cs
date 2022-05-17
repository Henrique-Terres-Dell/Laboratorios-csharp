IEstadoBinario[] lista = new IEstadoBinario[2];
lista[0] = new Lampada(110, 60);
lista[0].Ligar();
lista[1] = new TermometroEletrico();
for(int i = 0; i < 2; i++) {
    Console.WriteLine(lista[i].Estado);
}

Console.WriteLine("Ar condicionado: ");
ArCondicionado ar = new ArCondicionado();
ar.Ligar();
Console.WriteLine(ar.Estado);
Console.WriteLine("Temperatura = " + ar.Temperatura + " graus celsius");
ar.Aumentar(1.0);
ar.Aumentar(4.0);
ar.Diminuir(2.0);
Console.WriteLine("Temperatura = " + ar.Temperatura + " graus celsius");