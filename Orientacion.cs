public abstract class Orientacion
{
    public string? Nombre { get; set; }

    public abstract void PonerElemento(Contenedor contenedor, ElementoMapa elemento);
}
