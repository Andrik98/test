using Chronometer.Core.Time.Interfaces;
using Chronometer.Core.Time.Models;
using System;
using System.Windows.Threading;

namespace Chronometer.Core.Time
{
    public class TimeDispatcher : ITimeDispatcher
    {
        DispatcherTimer ChronoTimer { get; set; }
        private readonly TimeLabel Timer = new TimeLabel();

        public TimeDispatcher()
        {
            ChronoTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            ChronoTimer.Tick += Tick;
        }

        public void Start()
        {
            if (!ChronoTimer.IsEnabled)
            {
                ChronoTimer.Start();
            }
        }

        public void Stop()
        {
            ChronoTimer.Stop();
        }

        public void Restart()
        {
            Timer.Seconds = 0;
        }

        public TimeLabel GetTimeLabel()
        {
            return Timer;
        }

        private void Tick(object sender, EventArgs e)
        {
            Timer.Seconds++;
        }
    }
}
