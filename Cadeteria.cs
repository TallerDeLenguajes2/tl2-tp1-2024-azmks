class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listadoCadete;

    public Cadeteria(string nombre, string telefono, List<Cadete> listadoCadete)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.listadoCadete = listadoCadete;
    }
}