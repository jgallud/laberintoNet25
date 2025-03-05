using System.Collections.Generic;

public class Juego
{
    public required Laberinto Laberinto { get; set; }
    public List<Bicho> Bichos { get; set; } = new List<Bicho>();

    public void addBicho(Bicho bicho)
    {
        Bichos.Add(bicho);
    }

    public void removeBicho(Bicho bicho)
    {
        Bichos.Remove(bicho);
    }

    public Habitacion getHabitacion(int numero)
    {
        return Laberinto.getHabitacion(numero);
    }

    public void fabricarLaberinto2Hab()
    {
        Laberinto = new Laberinto();

        Habitacion habitacion1 = new Habitacion { Numero = 1 };
        Habitacion habitacion2 = new Habitacion { Numero = 2 };
        Puerta puerta = new Puerta { Lado1 = habitacion1, Lado2 = habitacion2 };

        habitacion1.Sur = puerta;
        habitacion2.Norte = puerta;

        Laberinto.addHabitacion(habitacion1);
        Laberinto.addHabitacion(habitacion2);

        Bicho bicho = new Bicho { Modo = new Agresivo() };
        addBicho(bicho);
        habitacion1.entrar(bicho);
    }

    public void fabricarLaberinto4Hab()
    {
        Laberinto = new Laberinto();

        Habitacion habitacion1 = new Habitacion { Numero = 1 };
        Habitacion habitacion2 = new Habitacion { Numero = 2 };
        Habitacion habitacion3 = new Habitacion { Numero = 3 };
        Habitacion habitacion4 = new Habitacion { Numero = 4 };

        Puerta puerta12 = new Puerta { Lado1 = habitacion1, Lado2 = habitacion2 };
        Puerta puerta13 = new Puerta { Lado1 = habitacion1, Lado2 = habitacion3 };
        Puerta puerta24 = new Puerta { Lado1 = habitacion2, Lado2 = habitacion4 };
        Puerta puerta34 = new Puerta { Lado1 = habitacion3, Lado2 = habitacion4 };

        habitacion1.Sur = puerta12;
        habitacion2.Norte = puerta12;

        habitacion1.Este = puerta13;
        habitacion3.Oeste = puerta13;

        habitacion2.Este = puerta24;
        habitacion4.Oeste = puerta24;

        habitacion3.Sur = puerta34;
        habitacion4.Norte = puerta34;

        Laberinto.addHabitacion(habitacion1);
        Laberinto.addHabitacion(habitacion2);
        Laberinto.addHabitacion(habitacion3);
        Laberinto.addHabitacion(habitacion4);

        Bicho bicho1 = new Bicho { Modo = new Agresivo() };
        addBicho(bicho1);
        habitacion1.entrar(bicho1);

        Bicho bicho2 = new Bicho { Modo = new Perezoso() };
        addBicho(bicho2);
        habitacion2.entrar(bicho2);

        Bicho bicho3 = new Bicho { Modo = new Agresivo() };
        addBicho(bicho3);
        habitacion3.entrar(bicho3);

        Bicho bicho4 = new Bicho { Modo = new Perezoso() };
        addBicho(bicho4);
        habitacion4.entrar(bicho4);
    }
}
