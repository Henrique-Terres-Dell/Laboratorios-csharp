List<Pessoa> pessoas = new List<Pessoa> {
    new Pessoa{ Nome = "Ana", DataNascimento = new DateTime(1980, 3, 14), Casada = true },
    new Pessoa{ Nome = "Paulo", DataNascimento = new DateTime(1978, 10, 23), Casada = true },
    new Pessoa{ Nome = "Maria", DataNascimento = new DateTime(2000, 1, 10), Casada = false },
    new Pessoa{ Nome = "Carlos", DataNascimento = new DateTime(1999, 12, 12), Casada = false },
    new Pessoa{ Nome = "Juninho", DataNascimento = new DateTime(1978, 11, 11), Casada = true },
    new Pessoa{ Nome = "Júlia", DataNascimento = new DateTime(1982, 4, 12), Casada = true },
    new Pessoa{ Nome = "Vitor", DataNascimento = new DateTime(1997, 5, 7), Casada = false }
};

var linq1 =
    from p in pessoas
    where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
    select p;

foreach (var pessoa in linq1) {
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));

foreach (var pessoa in linq2) {
    Console.WriteLine(pessoa);
}

Console.WriteLine();

//3 - Exercícios:
//1. Consulta que retorna as pessoas agrupadas em casadas e solteiras e também o número de pessoas...
//casadas e solteiras
var linq3 =
    pessoas.GroupBy(
        pessoa => pessoa.Casada,
        pessoa => pessoa.Nome,
        (casada, nome) => new {
            Key = casada,
            Quantidade = nome.Count(),
            Nomes = nome
        }
    );

foreach (var pessoa in linq3) {
    Console.WriteLine("Casada = " +  pessoa.Key + ", Quantidade = " + pessoa.Quantidade);
    foreach (string nome in pessoa.Nomes) {
        Console.WriteLine(nome);
    }
    Console.WriteLine();
}

//2. Consulta que retorna a pessoa mais velha
var linq4 = pessoas.MinBy(pessoa => pessoa.DataNascimento);
Console.WriteLine("Pessoa mais velha: " + linq4.Nome);

//3. Consulta que retorne a pessoa solteira mais nova
var linq5 = pessoas.Where(p => p.Casada == false).MaxBy(pessoa => pessoa.DataNascimento);
Console.WriteLine("Pessoa solteira mais nova: " + linq5.Nome);