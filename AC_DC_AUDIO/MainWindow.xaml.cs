using System;
using System.Timers;
using System.Windows;


namespace AC_DC_AUDIO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Timer timer;
        private double duration;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RecordButton_Click(object sender, RoutedEventArgs e)
        {        
            duration = 0;
            timer = new Timer(1000);
            timer.Elapsed += (s, args) =>
            {
                Dispatcher.Invoke(() =>
                {
                    Timer.Text = TimeSpan.FromSeconds(duration++).ToString();
                });
            };

            timer.Start();

        }
    }
}
