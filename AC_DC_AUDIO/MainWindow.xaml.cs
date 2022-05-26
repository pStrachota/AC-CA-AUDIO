using Microsoft.Win32;
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
        private string fileNameToSave;
        private string fileNameToLoad;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RecordButton_Click(object sender, RoutedEventArgs e)
        {

            var dialog = new SaveFileDialog();
            dialog.Filter = "Wave files | *.wav";

            if (dialog.ShowDialog() != true)
                return;

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

        private void PlayWavFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Wave files | *.wav";

            if (dialog.ShowDialog() != true)
                return;

            fileNameToLoad = dialog.FileName;        
        }
    }
}
