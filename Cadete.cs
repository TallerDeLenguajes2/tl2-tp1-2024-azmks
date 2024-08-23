class Cadete
{
    private int id;
    private string nombre;
    private string telefono;
    private List<Pedido> listadoPedidos;

    public Cadete(int id, string nombre, string telefono, List<Pedido> listadoPedidos)
    {
        this.id = id;
        this.nombre = nombre;
        this.telefono = telefono;
        this.listadoPedidos = listadoPedidos;
    }
}