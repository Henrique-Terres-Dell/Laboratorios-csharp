string[] lista = { "Júlio", "Lúcia", "Daniel", "João" };

Console.Write("Array antes da ordenação: ");
for(int i = 0; i < lista.Length; i++) {
    Console.Write(lista[i] + " ");
}

Console.WriteLine();

Array.Sort(lista);
Console.Write("Array após ordenação: ");
for(int i = 0; i < lista.Length; i++) {
    Console.Write(lista[i] + " ");
}

Console.WriteLine();

Pessoa[] lista2 = {
    new Pessoa("José", 25),
    new Pessoa("Ana", 28),
    new Pessoa("Paulo", 20)
};

Array.Sort(lista2);
Console.Write("Array de pessoas depois da ordenação: ");
for(int i = 0; i < lista2.Length; i++) {
    Console.Write(lista2[i].Nome + " ");
}

Console.WriteLine();

Console.Write("Array de pessoas depois da ordenação por OrderBy: ");
List<Pessoa> ordenaPorIdade = lista2.OrderBy(pessoa => pessoa.Idade).ToList();
foreach (Pessoa pessoa in ordenaPorIdade)
    Console.WriteLine(pessoa.Nome + ": " + pessoa.Idade + " anos");