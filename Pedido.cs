public class Pedido
{
    private int id;
    private string obs;
    private double monto;
    private Cliente cliente;
    public Cadete cadete {get; set;}
    public Estado estado {get; set;}

    public Pedido(int id, string obs, double monto, string nombre, string dir, string tel, string datosDir, Cadete cadete, Estado estado)
    {
        this.id = id;
        this.obs = obs;
        this.monto = monto;
        cliente = new Cliente(nombre, dir, tel, datosDir);
        this.cadete = cadete;
        this.estado = estado;
    }

    public int Id()
    {
        return id;
    }

    public string Obs()
    {
        return obs;
    }

    public double Monto()
    {
        return monto;
    }

    private class Cliente
    {
        private string nombre;
        private string direccion;
        private string telefono;
        private string datosdireccion;

        public Cliente(string nombre, string direccion, string telefono, string datosdireccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.datosdireccion = datosdireccion;
        }
    }

    public enum Estado
    {
        Pendiente,
        Aceptado,
        EnProceso,
        Entregado
    }
}