using SOLID.Interfaces;

namespace SOLID
{
    public class GameController
    {
        private readonly IGameSettings _settings;
        private readonly IRandomGenerator _generatorNumber;
        private readonly int _gameNumber;
        private int _attemptsCount;
        private int _totalAttempts;

        public GameController(IGameSettings settings, IRandomGenerator generatorNumber)
        {
            _settings = settings;
            _generatorNumber = generatorNumber;
            _gameNumber = _generatorNumber.GetNumber(_settings.MinNum, _settings.MaxNum);
            _attemptsCount = _settings.Attempts;
            _totalAttempts = _settings.Attempts;
        }

        public bool CompareNumbers(int userNumber, out string message)
        {
            _attemptsCount--;

            if (userNumber == _gameNumber)
            {
                message = $"Вы угадали число! У вас осталось {_totalAttempts - _attemptsCount} попыток.";
                return true;
            }

            if (_attemptsCount == 0)
            {
                message = $"Вы израсходовали все {_totalAttempts} попытки! Загаданное число : {_gameNumber}";
                return false;
            }

            message = userNumber < _gameNumber ? "Загаданное число больше!" : "Загаданное число меньше!";

            return false;
        }
    }     
}