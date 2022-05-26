using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
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

        [DllImport("winmm.dll")]
        static extern long mciSendString(string strCommand, String strReturn, int iReturnLength, int hwndCallback);

        private void RecordButton_Click(object sender, RoutedEventArgs e)
        {
            if (SampleRates.SelectedItem == null || BitsDepth.SelectedItem == null)
            {
                MessageBox.Show("Select sample rate and bit depth");
                return;
            }

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
            fileNameToSave = dialog.FileName;

            string chosenSampleRate = SampleRates.SelectedItem.ToString();
            string chosenBitsDepth = BitsDepth.SelectedItem.ToString();

            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString($"set recsound time format ms bitspersample {chosenBitsDepth} channels 1 samplespersec {chosenSampleRate} bytespersec 192000 alignment 4", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);

            RecordButton.IsEnabled = false;
            StopButton.IsEnabled = true;

        }

        private void PlayWavFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Wave files | *.wav";

            if (dialog.ShowDialog() != true)
                return;

            fileNameToLoad = dialog.FileName;

            Dispatcher.Invoke(() =>
            {
                mciSendString($"play {fileNameToLoad} wait", "", 0, 0);
            });
        }
    }
}
