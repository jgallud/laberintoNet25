public class Sur : Orientacion
{
    public Sur()
    {
        Nombre = "Sur";
    }

    public override void PonerElemento(Contenedor contenedor, ElementoMapa elemento)
    {
        contenedor.Sur = elemento;
    }
}
