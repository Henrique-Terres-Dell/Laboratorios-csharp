class ContaCorrente {
    public string nomeTitular { get; set; }
    public DateTime dataCriacao { get; init; }
    public decimal saldo { get; set; }
    private int transacoes = 0;
    private decimal acumuladorSaldo = 0;
    public decimal saldoMedio {
        get { return acumuladorSaldo / transacoes; }
    }

    public ContaCorrente(decimal val, string nomeTitular) {
        saldo = val;
        this.nomeTitular = nomeTitular;
        this.dataCriacao = DateTime.Now;
    }

    public void Depositar(decimal val) {
        saldo += val;
        acumuladorSaldo += saldo;
        transacoes++;
    }

    public void Sacar(decimal val) {
        saldo -= val;
        acumuladorSaldo += saldo;
        transacoes++;
    }
}