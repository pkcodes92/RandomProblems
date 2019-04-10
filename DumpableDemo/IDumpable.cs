namespace DumpableDemo
{
    public interface IDumpable
    {
        string Name { get; set; }
        void Dump(); 
    }
}
