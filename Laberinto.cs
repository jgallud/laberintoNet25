using System.Collections.Generic;

public class Laberinto : Contenedor
{
    public void addHabitacion(Habitacion habitacion)
    {
        addHijo(habitacion);
    }

    public void removeHabitacion(Habitacion habitacion)
    {
        removeHijo(habitacion);
    }

    public override void entrar(Ente alguien)
    {
        System.Console.WriteLine(alguien.Nombre + " entra en el laberinto");
    }

    public Habitacion getHabitacion(int numero)
    {
        foreach (ElementoMapa hijo in Hijos)
        {
            if (hijo.esHabitacion() && ((Habitacion)hijo).Numero == numero)
            {
                return (Habitacion)hijo;
            }
        }
        return null;
    }
}
