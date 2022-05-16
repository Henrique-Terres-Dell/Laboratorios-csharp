Circulo circ1 = new Circulo();
Console.WriteLine(circ1);
Circulo circ2 = new Circulo(2.4, 5, 3);
Console.WriteLine(circ2);
CirculoColorido circ3 = new CirculoColorido();
Console.WriteLine(circ3);
CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
Console.WriteLine(circ4);
CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido(3.4, 4.6, 1, "rosa", System.Drawing.Color.Green);
Console.WriteLine(circ5);
CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(3.4, 4.6, 1, "amarelo", System.Drawing.Color.Red);
Console.WriteLine(circ6);

List<Circulo> listaCirculos = new List<Circulo>();
listaCirculos.Add(circ1);
listaCirculos.Add(circ2);
listaCirculos.Add(circ3);
listaCirculos.Add(circ4);
listaCirculos.Add(circ5);
listaCirculos.Add(circ6);

Console.WriteLine();
Console.WriteLine("Lista de Círculos: ");
foreach(var circulo in listaCirculos) {
    Console.WriteLine(circulo);
}