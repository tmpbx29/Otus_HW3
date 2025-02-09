using SOLID.Interfaces;

namespace SOLID
{
    public class GameSettings : IGameSettings
    {
        public int MinNum { get; set; }
        public int MaxNum { get; set; }
        public int Attempts { get; set; }
        public GameSettings(int minNum, int maxNum, int attempts)
        {
            MinNum = minNum;
            MaxNum = maxNum;
            Attempts = attempts;
        }
    }
}
