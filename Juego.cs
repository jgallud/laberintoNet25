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
        Creator creator = new Creator();
        Laberinto = creator.CrearLaberinto();

        Habitacion habitacion1 = creator.CrearHabitacion();
        habitacion1.Numero = 1;
        Habitacion habitacion2 = creator.CrearHabitacion();
        habitacion2.Numero = 2;
        Puerta puerta = creator.CrearPuerta();
        puerta.Lado1 = habitacion1;
        puerta.Lado2 = habitacion2;

        Sur sur = new Sur();
        Norte norte = new Norte();

        habitacion1.ponerElementoEnOrientacion(puerta, sur);
        habitacion2.ponerElementoEnOrientacion(puerta, norte);

        Laberinto.addHabitacion(habitacion1);
        Laberinto.addHabitacion(habitacion2);

        Bicho bicho = new Bicho { Modo = new Agresivo() };
        addBicho(bicho);
        habitacion1.entrar(bicho);
    }

    public void fabricarLaberinto2HabFM()
    {
        Creator creator = new Creator();
        Laberinto = creator.CrearLaberinto();

        Habitacion habitacion1 = creator.CrearHabitacion();
        habitacion1.Numero = 1;
        Habitacion habitacion2 = creator.CrearHabitacion();
        habitacion2.Numero = 2;
        Puerta puerta = creator.CrearPuerta();
        puerta.Lado1 = habitacion1;
        puerta.Lado2 = habitacion2;

        Sur sur = new Sur();
        Norte norte = new Norte();

        habitacion1.ponerElementoEnOrientacion(puerta, sur);
        habitacion2.ponerElementoEnOrientacion(puerta, norte);

        Laberinto.addHabitacion(habitacion1);
        Laberinto.addHabitacion(habitacion2);

        Bicho bicho = creator.CrearBichoAgresivo();
        addBicho(bicho);
        habitacion1.entrar(bicho);
    }

    public void fabricarLaberinto4Hab()
    {
        Creator creator = new Creator();
        Laberinto = creator.CrearLaberinto();

        Habitacion habitacion1 = creator.CrearHabitacion();
        habitacion1.Numero = 1;
        Habitacion habitacion2 = creator.CrearHabitacion();
        habitacion2.Numero = 2;
        Habitacion habitacion3 = creator.CrearHabitacion();
        habitacion3.Numero = 3;
        Habitacion habitacion4 = creator.CrearHabitacion();
        habitacion4.Numero = 4;

        Puerta puerta12 = creator.CrearPuerta();
        puerta12.Lado1 = habitacion1;
        puerta12.Lado2 = habitacion2;
        Puerta puerta13 = creator.CrearPuerta();
        puerta13.Lado1 = habitacion1;
        puerta13.Lado2 = habitacion3;
        Puerta puerta24 = creator.CrearPuerta();
        puerta24.Lado1 = habitacion2;
        puerta24.Lado2 = habitacion4;
        Puerta puerta34 = creator.CrearPuerta();
        puerta34.Lado1 = habitacion3;
        puerta34.Lado2 = habitacion4;

        Sur sur = new Sur();
        Norte norte = new Norte();
        Este este = new Este();
        Oeste oeste = new Oeste();

        habitacion1.ponerElementoEnOrientacion(puerta12, sur);
        habitacion2.ponerElementoEnOrientacion(puerta12, norte);

        habitacion1.ponerElementoEnOrientacion(puerta13, este);
        habitacion3.ponerElementoEnOrientacion(puerta13, oeste);

        habitacion2.ponerElementoEnOrientacion(puerta24, este);
        habitacion4.ponerElementoEnOrientacion(puerta24, oeste);

        habitacion3.ponerElementoEnOrientacion(puerta34, sur);
        habitacion4.ponerElementoEnOrientacion(puerta34, norte);

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

    public void fabricarLaberinto4HabFM()
    {
        Creator creator = new Creator();
        Laberinto = creator.CrearLaberinto();

        Habitacion habitacion1 = creator.CrearHabitacion();
        habitacion1.Numero = 1;
        Habitacion habitacion2 = creator.CrearHabitacion();
        habitacion2.Numero = 2;
        Habitacion habitacion3 = creator.CrearHabitacion();
        habitacion3.Numero = 3;
        Habitacion habitacion4 = creator.CrearHabitacion();
        habitacion4.Numero = 4;

        Puerta puerta12 = creator.CrearPuerta();
        puerta12.Lado1 = habitacion1;
        puerta12.Lado2 = habitacion2;
        Puerta puerta13 = creator.CrearPuerta();
        puerta13.Lado1 = habitacion1;
        puerta13.Lado2 = habitacion3;
        Puerta puerta24 = creator.CrearPuerta();
        puerta24.Lado1 = habitacion2;
        puerta24.Lado2 = habitacion4;
        Puerta puerta34 = creator.CrearPuerta();
        puerta34.Lado1 = habitacion3;
        puerta34.Lado2 = habitacion4;

        Sur sur = new Sur();
        Norte norte = new Norte();
        Este este = new Este();
        Oeste oeste = new Oeste();

        habitacion1.ponerElementoEnOrientacion(puerta12, sur);
        habitacion2.ponerElementoEnOrientacion(puerta12, norte);

        habitacion1.ponerElementoEnOrientacion(puerta13, este);
        habitacion3.ponerElementoEnOrientacion(puerta13, oeste);

        habitacion2.ponerElementoEnOrientacion(puerta24, este);
        habitacion4.ponerElementoEnOrientacion(puerta24, oeste);

        habitacion3.ponerElementoEnOrientacion(puerta34, sur);
        habitacion4.ponerElementoEnOrientacion(puerta34, norte);

        Laberinto.addHabitacion(habitacion1);
        Laberinto.addHabitacion(habitacion2);
        Laberinto.addHabitacion(habitacion3);
        Laberinto.addHabitacion(habitacion4);

        Bicho bicho1 = creator.CrearBichoAgresivo();
        addBicho(bicho1);
        habitacion1.entrar(bicho1);

        Bicho bicho2 = creator.CrearBichoPerezoso();
        addBicho(bicho2);
        habitacion2.entrar(bicho2);

        Bicho bicho3 = creator.CrearBichoAgresivo();
        addBicho(bicho3);
        habitacion3.entrar(bicho3);

        Bicho bicho4 = creator.CrearBichoPerezoso();
        addBicho(bicho4);
        habitacion4.entrar(bicho4);
    }
}
