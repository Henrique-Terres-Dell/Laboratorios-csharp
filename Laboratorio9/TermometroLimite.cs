public class TermometroLimite : Termometro {
    private double limiteSuperior;
    private bool disparadoEventoLimiteSuperior;

    public TermometroLimite(double ls) {
        limiteSuperior = ls;
        disparadoEventoLimiteSuperior = false;
    }

    public double LimiteSuperior {
        get { return limiteSuperior; }
        set { limiteSuperior = value; }
    }

    public delegate void MeuDelegate(string msg);

    public event MeuDelegate LimiteSuperiorEvent;
    public event MeuDelegate TemperaturaNormalizadaEvent;

    private void OnLimiteSuperiorEvent() {
        if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
            if (LimiteSuperiorEvent != null) {
                LimiteSuperiorEvent("Atenção: temperatura acima do limite!!! - Temperatura = " + this.Temperatura);
                disparadoEventoLimiteSuperior = true;
            }
    }

    private void NormalizedEvent() {
            if ((this.Temperatura < limiteSuperior) && (!disparadoEventoLimiteSuperior)) {
                if(TemperaturaNormalizadaEvent != null) {
                    TemperaturaNormalizadaEvent("Temperatura normalizada! - Temperatura = " + this.Temperatura);
                }
            }
    }
    
    public override void Aumentar() {
        base.Aumentar();
        OnLimiteSuperiorEvent();
    }

    public override void Aumentar(double valor) {
        base.Aumentar(valor);
        OnLimiteSuperiorEvent();
    }

    public override void Diminuir() {
        base.Diminuir();
        if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior)) {
            disparadoEventoLimiteSuperior = false;
            NormalizedEvent();
        }
    }

    public override void Diminuir(double valor) {
        base.Diminuir(valor);
        if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior)) {
            disparadoEventoLimiteSuperior = false;
            NormalizedEvent();
        }
    }
}