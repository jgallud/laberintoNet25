public class Este : Orientacion
{
    public Este()
    {
        Nombre = "Este";
    }

    public override void PonerElemento(Contenedor contenedor, ElementoMapa elemento)
    {
        contenedor.Este = elemento;
    }
}
