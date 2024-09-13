using System.Data.Common;

public class Cadete
{
    private int id;
    private string nombre;
    private string telefono;

    public Cadete(int id, string nombre, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public int Id() => id;
}