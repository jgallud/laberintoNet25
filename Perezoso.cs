public class Perezoso : Modo
{
    public Perezoso()
    {
        Nombre = "Perezoso";
    }

    public override void Dormir(Bicho bicho)
    {
        // Los perezosos duermen mucho
    }

    public override void Caminar(Bicho bicho)
    {
        // Los perezosos caminan lento
    }

    public override void Atacar(Bicho bicho)
    {
        // Los perezosos no atacan
    }
}
