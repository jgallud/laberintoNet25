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
}
