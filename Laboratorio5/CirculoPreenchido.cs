using System.Drawing;

public class CirculoColoridoPreenchido : CirculoColorido {
    private Color corAdicionalPreenchimento;

    public Color CorAdicionalPreenchimento {
        get { return corAdicionalPreenchimento; }
        set { corAdicionalPreenchimento = value; }
    }

    public CirculoColoridoPreenchido(double x, double y, double r, string cor, Color corAdicional)
        : base(x, y, r, cor)
    {
        corAdicionalPreenchimento = corAdicional;
    }

    public override string ToString() {
        return base.ToString() + " | Cor Adicional Preenchimento: " + CorAdicionalPreenchimento;
    }
}