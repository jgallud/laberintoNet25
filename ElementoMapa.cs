public abstract class ElementoMapa
{
    public abstract void entrar(Ente alguien);
    public virtual bool esHabitacion()
    {
        return false;
    }
}
