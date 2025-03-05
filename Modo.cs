public abstract class Modo
{
    public string? Nombre { get; set; }

    public abstract void Dormir(Bicho bicho);
    public abstract void Caminar(Bicho bicho);
    public abstract void Atacar(Bicho bicho);

    public virtual void Actuar(Bicho bicho)
    {
        Dormir(bicho);
        Caminar(bicho);
        Atacar(bicho);
    }
}
