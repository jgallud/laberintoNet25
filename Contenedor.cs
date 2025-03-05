using System.Collections.Generic;

public abstract class Contenedor : ElementoMapa
{
    public List<ElementoMapa> Hijos { get; set; } = new List<ElementoMapa>();

    public void addHijo(ElementoMapa hijo)
    {
        Hijos.Add(hijo);
    }

    public void removeHijo(ElementoMapa hijo)
    {
        Hijos.Remove(hijo);
    }

    public List<Orientacion> Orientaciones { get; set; } = new List<Orientacion>();

    public void ponerElementoEnOrientacion(ElementoMapa elemento, Orientacion orientacion)
    {
        orientacion.PonerElemento(this, elemento);
    }

    public ElementoMapa? Norte { get; set; }
    public ElementoMapa? Sur { get; set; }
    public ElementoMapa? Este { get; set; }
    public ElementoMapa? Oeste { get; set; }
}
