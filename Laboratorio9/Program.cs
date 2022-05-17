static void TrataEvento(string msg) { 
    Console.WriteLine(msg); 
}   

TermometroLimite term = new TermometroLimite(5);
Console.WriteLine(term.ToString());

term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataEvento);
term.TemperaturaNormalizadaEvent += new TermometroLimite.MeuDelegate(TrataEvento);

term.Aumentar(6);
Console.WriteLine(term.ToString());

term.Diminuir(2);
Console.WriteLine(term.ToString());