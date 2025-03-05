public class Creator
{
    public Agresivo CrearAgresivo()
    {
        return new Agresivo();
    }

    public Perezoso CrearPerezoso()
    {
        return new Perezoso();
    }

    public Bicho CrearBichoAgresivo()
    {
        return new Bicho { Modo = CrearAgresivo() };
    }

    public Bicho CrearBichoPerezoso()
    {
        return new Bicho { Modo = CrearPerezoso() };
    }

    public Habitacion CrearHabitacion()
    {
        return new Habitacion();
    }

    public Laberinto CrearLaberinto()
    {
        return new Laberinto();
    }

    public Juego CrearJuego()
    {
        return new Juego { Laberinto = new Laberinto() };
    }

    public Pared CrearPared()
    {
        return new Pared();
    }

    public Puerta CrearPuerta()
    {
        return new Puerta { Lado1 = new Habitacion(), Lado2 = new Habitacion() };
    }

    public Norte CrearNorte()
    {
        return new Norte();
    }

    public Sur CrearSur()
    {
        return new Sur();
    }

    public Este CrearEste()
    {
        return new Este();
    }

    public Oeste CrearOeste()
    {
        return new Oeste();
    }
}
