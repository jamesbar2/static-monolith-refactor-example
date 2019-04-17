namespace StaticMonolith
{
    public interface IRepositoryA
    {
        Widget Get(int id);
        Widget Set(int id, string value);
    }
}