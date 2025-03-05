public class Habitacion : Contenedor
{
    public int Numero { get; set; }
    public ElementoMapa? Norte { get; set; }
    public ElementoMapa? Sur { get; set; }
    public ElementoMapa? Este { get; set; }
    public ElementoMapa? Oeste { get; set; }

    public override void entrar(Ente alguien)
    {
        System.Console.WriteLine(alguien.Nombre + " entra en la habitación " + Numero);
    }

    public override bool esHabitacion()
    {
        return true;
    }
}
