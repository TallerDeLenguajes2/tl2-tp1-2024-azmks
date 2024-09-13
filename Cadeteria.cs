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
        Pedido miPedido = listaPedidos.Find(ped => ped.Id() == idPedido);
        Cadete miCadete = listaCadetes.Find(cad => cad.Id() == idCadete);

        if (miPedido == null) WriteLine("Error. Pedido inexistente.");
        else if (miCadete == null) WriteLine("Error. Cadete inexistente.");
        else if (miPedido.Estado() != Status.Pendiente) WriteLine("El pedido ya se encuentra asignado.");
        else
        {

        }
    }

    public void ReasignarCadeteAPedido(int idPedido, int idCadete)
    {
        //
    }
}