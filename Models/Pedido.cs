namespace SaPlaceta_api.Models;
public class PEDIDO
{
    public PEDIDO(int NUM_PEDIDO, int NUM_PLATO, DateTime DIA, int UNIDAD)
    {
        this.NUM_PEDIDO = NUM_PEDIDO;
        this.NUM_PLATO = NUM_PLATO;
        this.DIA = DIA;
        this.UNIDAD = UNIDAD;
    }
    public int NUM_PEDIDO { get; set; }
    public int NUM_PLATO { get; set; }
    public DateTime DIA { get; set; }
    public int UNIDAD { get; set; }
}