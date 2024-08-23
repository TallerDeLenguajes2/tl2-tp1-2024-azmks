class Pedido
{
    private int nro;
    private string obs;
    private Cliente cliente;
    private Estado estado;

    public Pedido(int nro, string obs, Cliente cliente, Estado estado)
    {
        this.nro = nro;
        this.obs = obs;
        this.cliente = cliente;
        this.estado = estado;
    }
}

public enum Estado
{
    Pendiente,
    Aceptado,
    EnProceso,
    Entregado
}