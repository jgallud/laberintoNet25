public class Norte : Orientacion
{
    public Norte()
    {
        Nombre = "Norte";
    }

    public override void PonerElemento(Contenedor contenedor, ElementoMapa elemento)
    {
        contenedor.Norte = elemento;
    }
}
