public class Oeste : Orientacion
{
    public Oeste()
    {
        Nombre = "Oeste";
    }

    public override void PonerElemento(Contenedor contenedor, ElementoMapa elemento)
    {
        contenedor.Oeste = elemento;
    }
}
