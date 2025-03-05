public class Pared : ElementoMapa
{
    public override void entrar(Ente alguien)
    {
        System.Console.WriteLine(alguien.Nombre + " choca contra la pared");
    }
}
