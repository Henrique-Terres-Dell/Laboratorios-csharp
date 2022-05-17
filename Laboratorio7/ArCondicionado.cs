public class ArCondicionado : Termometro, IEstadoBinario {
    private EstadoBinario estado = EstadoBinario.Desligado;
    private double temperatura;

    public ArCondicionado() {
        temperatura = 22.0;
    }

    public override double Temperatura {
        get { return temperatura; }
    }

    public void Ligar() {
        estado = EstadoBinario.Ligado;
    }

    public void Desligar() {
        estado = EstadoBinario.Desligado;
    }
    
    public EstadoBinario Estado {
        get { return estado; }
    }

    public override void Aumentar(double t) {
        this.temperatura += t;
    }

    public override void Diminuir(double t) {
        this.temperatura -= t;
    }
}