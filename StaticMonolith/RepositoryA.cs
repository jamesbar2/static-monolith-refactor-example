namespace StaticMonolith
{
    public class RepositoryA : IRepositoryA
    {
        public Widget Get(int id)
        {
            return new Widget {Id = id};
        }

        public Widget Set(int id, string value)
        {
            return new Widget { Id = id, Value = value};
        }
    }
}