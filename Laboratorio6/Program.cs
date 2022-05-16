ContaPoupanca conta1 = new ContaPoupanca(0.10M, new DateTime(2022, 5, 16, 11, 15, 30), "Fábio");
ContaPoupanca conta2 = new ContaPoupanca(0.20M, new DateTime(2004, 8, 3, 12, 14, 29), "Alessandro");
ContaPoupanca conta3 = new ContaPoupanca(0.30M, new DateTime(2022, 5, 16, 9, 13, 22), "Júlia");
ContaPoupanca conta4 = new ContaPoupanca(0.40M, new DateTime(2002, 6, 6, 7, 12, 11), "Vitor");
ContaPoupanca conta5 = new ContaPoupanca(0.50M, new DateTime(2001, 5, 9, 6, 11, 17), "Vitória");
ContaPoupanca conta6 = new ContaPoupanca(0.60M, new DateTime(2022, 5, 16, 5, 10, 15), "Pablo");

conta1.Depositar(500M);
conta1.Sacar(100M);
conta1.AdicionarRendimento();

conta2.Depositar(1500M);
conta2.Sacar(1000M);
conta2.AdicionarRendimento();

conta3.Depositar(300M);
conta3.Sacar(50M);
conta3.AdicionarRendimento();

conta4.Depositar(200M);
conta4.Sacar(100M);
conta4.AdicionarRendimento();

conta5.Depositar(5000M);
conta5.Sacar(2500M);
conta5.AdicionarRendimento();

conta6.Depositar(100M);
conta6.Sacar(50M);
conta6.AdicionarRendimento();

List<ContaPoupanca> contas = new List<ContaPoupanca>();
contas.Add(conta1);
contas.Add(conta2);
contas.Add(conta3);
contas.Add(conta4);
contas.Add(conta5);
contas.Add(conta6);

Console.WriteLine("Contas: ");
foreach(var conta in contas) {
    Console.WriteLine(conta);
}