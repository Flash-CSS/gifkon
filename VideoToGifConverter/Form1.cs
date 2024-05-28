using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VideoToGifConverter
{
    public partial class MainForm : Form
    {
        private string inputVideoPath = "";
        private string outputGifPath = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void selectVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputVideoPath = openFileDialog.FileName;
                inputVideoTextBox.Text = inputVideoPath;
            }
        }

        private void selectOutputButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "GIF Image|*.gif";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputGifPath = saveFileDialog.FileName;
                outputGifTextBox.Text = outputGifPath;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (inputVideoPath == "" || outputGifPath == "")
            {
                MessageBox.Show("Please select input video and output GIF paths!");
                return;
            }

            int width = (int)widthNumericUpDown.Value;
            int height = (int)heightNumericUpDown.Value;
            int fps = (int)fpsNumericUpDown.Value;

            string arguments = $"-i \"{inputVideoPath}\" -vf \"fps={fps},scale={width}:{height}\" \"{outputGifPath}\"";

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = @"C:\ffmpeg\ffmpeg.exe",
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForExit();
            }

            logListBox.Items.Add("Conversion completed!");
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
