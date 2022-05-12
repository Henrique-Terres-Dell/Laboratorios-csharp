Console.WriteLine("1 - Alocar, inicializar e acessar dados em uma lista");

List<string> listaStrings = new List<string>();
listaStrings.Add("Um");
listaStrings.Add("Hello");
listaStrings.Add("World");
Console.WriteLine(listaStrings[0]);
Console.WriteLine(listaStrings[1]);
Console.WriteLine(listaStrings[2]);
//listaStrings.add(10);

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("2 - Alocar, inicializar e acessar dados em uma fila");

Queue<Object> q = new Queue<object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());

Console.WriteLine();

//-------------------------------------------------------------------------------

Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());

Console.WriteLine();

//-------------------------------------------------------------------------------

Console.WriteLine("3 - Manipulando dicionários genéricos");

Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);
foreach (KeyValuePair<int, string> item in paises) {
    int codigo = item.Key;
    string pais = item.Value;
    Console.WriteLine("Código {0} = {1}", codigo, pais);
}

//-------------------------------------------------------------------------------

Console.WriteLine("4 - Exercícios:\n");