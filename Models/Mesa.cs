namespace SaPlaceta_api.Models
{
    public class MESA
    {
        public MESA(int NUM_MESA, int NUM_PEDIDO)
        {
            this.NUM_MESA = NUM_MESA;
            this.NUM_PEDIDO = NUM_PEDIDO;
        }
        public int NUM_MESA { get; set; }
        public int NUM_PEDIDO { get; set; }
    }
}