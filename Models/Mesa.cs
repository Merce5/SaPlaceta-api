namespace SaPlaceta_api.Models
{
    public class MESA
    {
        public MESA(int Num, IEnumerable<Pedido_Mesa> Pedido)
        {
            this.Num = Num;
            this.Pedido = Pedido;
        }
        public int Num { get; set; }
        public IEnumerable<Pedido_Mesa> Pedido { get; set; }
    }
}