public class Circulo {
    private double cordX;
    private double cordY;
    private double raio;

    public Circulo()
        : this(0, 0, 1)
    {
    }

    public Circulo(double x, double y, double r) {
        cordX = x;
        cordY = y;
        raio = Math.Abs(r);
    }
    
    public double CentroX {
        get { return cordX; }
        set { cordX = value; }
    }

    public double CentroY {
        get { return cordY; }
        set { cordY = value; }
    }

    public double Raio {
        get { return raio; }
        set { raio = value; }
    }

    public override string ToString()
    {
        return "(" + string.Format("{0:F2}", CentroX + "; "
                + string.Format("{0:F2}", CentroY) + ")"
                + " raio = " + string.Format("{0:F2}", raio));
    }
}