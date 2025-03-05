public class Agresivo : Modo
{
    public Agresivo()
    {
        Nombre = "Agresivo";
    }

    public override void Dormir(Bicho bicho)
    {
        // Los agresivos no duermen
    }

    public override void Caminar(Bicho bicho)
    {
        // Los agresivos caminan rapido
    }

    public override void Atacar(Bicho bicho)
    {
        // Los agresivos atacan
    }
}
