using Chronometer.Core.Time.Models;

namespace Chronometer.Core.Time.Interfaces
{
    public interface ITimeDispatcher
    {
        void Start();
        void Stop();
        void Restart();
        TimeLabel GetTimeLabel();
    }
}
