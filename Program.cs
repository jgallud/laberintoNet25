﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Juego juego = new Juego { Laberinto = new Laberinto() };
        Console.WriteLine("Fabricando laberinto de 4 habitaciones");
        juego.fabricarLaberinto4HabFM();

        if (juego.Laberinto != null)
        {
            Console.WriteLine("El laberinto tiene " + juego.Laberinto.Hijos.Count + " habitaciones.");
            Console.WriteLine("El juego tiene " + juego.Bichos.Count + " bichos.");
        }
    }
}
