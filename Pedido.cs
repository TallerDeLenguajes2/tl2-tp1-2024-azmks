public class Pedido
{
    private int nro;
    private string obs;
    private Cliente cliente;
    private Estado estado;

    public Pedido(int nro, string obs, string nombre, string direccion, string telefono, string datosdireccion, Estado estado)
    {
        this.nro = nro;
        this.obs = obs;
        this.cliente = new Cliente(nombre, direccion, telefono, datosdireccion);
        this.estado = estado;
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