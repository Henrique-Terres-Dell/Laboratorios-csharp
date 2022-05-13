ContaCorrente minhaConta = new ContaCorrente(340, "John Cena");
Console.WriteLine("Titular da conta: " + minhaConta.nomeTitular);
Console.WriteLine("Data de criação da conta: " + minhaConta.dataCriacao);

Console.WriteLine("Saldo inicial = " + minhaConta.saldo);

minhaConta.Depositar(100);
minhaConta.Sacar(50);
minhaConta.Depositar(2000);
minhaConta.Sacar(1550.50M);
minhaConta.Sacar(135.30M);

Console.WriteLine("Saldo da conta = " + minhaConta.saldo + "R$");
Console.WriteLine("Saldo médio da conta = " + minhaConta.saldoMedio + "R$");