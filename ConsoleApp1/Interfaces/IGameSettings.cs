namespace SOLID.Interfaces
{
    public interface IGameSettings
    {
       int MinNum { get; set; }
       int MaxNum { get; set; }
       int Attempts { get; set; }
    }
}
