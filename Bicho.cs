public class Bicho : Ente
{
    public required Modo Modo { get; set; }

    public void Actua()
    {
        Modo.Actuar(this);
    }
}
