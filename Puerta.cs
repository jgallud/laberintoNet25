public class Puerta : ElementoMapa
{
    public required ElementoMapa Lado1 { get; set; }
    public required ElementoMapa Lado2 { get; set; }
    public bool Abierta { get; set; }

    public override void entrar(Ente alguien)
    {
        if (Abierta)
        {
            System.Console.WriteLine(alguien.Nombre + " cruza la puerta");
        }
        else
        {
            System.Console.WriteLine(alguien.Nombre + " intenta abrir la puerta");
        }
    }
}
