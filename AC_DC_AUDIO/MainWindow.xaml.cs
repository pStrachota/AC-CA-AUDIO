using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
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

        public ObservableCollection<string> SampleRatesList { get; set; } =
         new ObservableCollection<string>() { "44100", "48000", "88200", "96000", "192000" };

        public ObservableCollection<string> BithDepthsList { get; set; } =
         new ObservableCollection<string>() { "8", "16", "32" };

        public MainWindow()
        {
            InitializeComponent();

            SampleRates.ItemsSource = SampleRatesList;
            BitsDepth.ItemsSource = BithDepthsList;
        }

        private void RecordButton_Click(object sender, RoutedEventArgs e)
        {
            if (SampleRates.SelectedItem == null || BitsDepth.SelectedItem == null)
            {
                MessageBox.Show("Select sample rate and bit depth");
                return;
            }

            var dialog = new SaveFileDialog
            {
                Filter = "Wave files | *.wav"
            };

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
            fileNameToSave = dialog.FileName;
        }

        private void PlayWavFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Wave files | *.wav"
            };

            if (dialog.ShowDialog() != true)
                return;

            fileNameToLoad = dialog.FileName;
        }
    }
}
