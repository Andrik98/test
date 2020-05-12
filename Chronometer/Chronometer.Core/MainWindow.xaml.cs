using Chronometer.Core.Time.Interfaces;
using Chronometer.Core.Time.Models;
using System.Windows;

namespace Chronometer.Core
{
    public partial class MainWindow : Window
    {
        private readonly ITimeDispatcher _timeDispatcher;

        public MainWindow(ITimeDispatcher timeDispatcher)
        {
            _timeDispatcher = timeDispatcher;
            InitializeComponent();
            this.DataContext = _timeDispatcher.GetTimeLabel();
        }

        public void StartEvent(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            StopButton.IsEnabled = true;
            RestartButton.IsEnabled = true;
            _timeDispatcher.Start();
        }

        public void StopEvent(object sender, RoutedEventArgs e)
        {
            StopButton.IsEnabled = false;
            StartButton.IsEnabled = true;
            _timeDispatcher.Stop();
        }

        public void RestartEvent(object sender, RoutedEventArgs e)
        {
            _timeDispatcher.Restart();
        }
    }
}
