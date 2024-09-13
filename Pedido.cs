using System.Console;

public class Pedido
{
    private int id;
    private string obs;
    private double monto;
    private Cliente cliente;
    public Cadete cadete {get; set;}
    public Status estado {get; set;}

    public Pedido(int id, string obs, double monto, string nombre, string dir, string tel, string datosDir)
    {
        this.id = id;
        this.obs = obs;
        this.monto = monto;
        cliente = new Cliente(nombre, dir, tel, datosDir);
        cadete = null;
        estado = Status.Pendiente;
    }

    public int Id() => id;
    public string Obs() => obs;
    public double Monto() => monto;
    public Status Estado() => estado;
    
    public void VerDireccionCliente()
    {
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine($"Cliente: {cliente.Nombre()}");
        ResetColor();
        WriteLine($"Direccion: {cliente.Direccion()}");
        WriteLine($"Datos (direccion): {cliente.DatosDireccion()}");
    }

    public void CambiarEstado(Status NuevoEstado) estado = NuevoEstado;

    private class Cliente
    {
        private string nombre;
        private string telefono;
        private string direccion;
        private string datosdireccion;

        public Cliente(string nombre, string direccion, string telefono, string datosdireccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.datosdireccion = datosdireccion;
        }
        
        
        public string Nombre() => nombre;
        public string Telefono() => telefono;
        public string Direccion() => direccion;
        public string DatosDireccion() => datosdireccion;
    }
}

public enum Status
{
    Pendiente,
    Aceptado,
    EnProceso,
    Entregado
}