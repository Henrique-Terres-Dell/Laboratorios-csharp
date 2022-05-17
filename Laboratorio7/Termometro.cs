public class Termometro {
    private double temperatura;

    public Termometro() {
        temperatura = 0.0;
    }

    virtual public double Temperatura {
        get { return temperatura; }
    }
    
    virtual public void Aumentar(double t) {
        temperatura += t;
    }

    virtual public void Diminuir(double t) {
        temperatura -= t;
    }
}