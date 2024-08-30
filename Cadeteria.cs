class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadetes;
    private List<Pedido> listaPedidos;

    public Cadeteria(string nombre, string telefono, List<Cadete> listaCadetes, List<Pedido> listaPedidos)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.listaCadetes = listaCadetes;
        this.listaPedidos =listaPedidos;
    }

    public double JornalACobrar(int idCadete)
    {
        List<Pedido> pedidosCadete = listaPedidos.Where(ped => ped.cadete.Id() == idCadete).ToList();
        List<double> montosCadete = new List<double>();
        foreach (Pedido ped in pedidosCadete) montosCadete.Add(ped.Monto());

        double montoTotal = montosCadete.Sum();
        return montoTotal;
    }

    public void AsignarCadeteAPedido(int idPedido, int idCadete)
    {
        //
    }
}