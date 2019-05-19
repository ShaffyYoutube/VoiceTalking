using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Globalization;

namespace VoiceTalking
{
    public partial class MainWindow : Form
    {
        string FilePathSave = String.Empty;
        SpeechSynthesizer speaker = new SpeechSynthesizer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Filter = "WAV|*.wav";
            SaveDialog.Title = "Save the voice";
            SaveDialog.ShowDialog();
            {
                Path.GetFullPath(SaveDialog.FileName);
                FilePathSave = SaveDialog.FileName;
                decimal RateListen = RateUpDown.Value;
                decimal VolumeListen = VolumeUpDown.Value;
                string TextListen = SpeechDialog.Text;
                string VoiceLanguage = LanguageVoice.SelectedIndex.ToString();
                string VoiceGender = GenderVoice.SelectedIndex.ToString();
                if (VoiceGender == "-1" || VoiceLanguage == "-1")
                {
                    MessageBox.Show("Please select an language and a gender.");
                    return;
                }
                SpeechSave(TextListen, RateListen, VolumeListen, FilePathSave, VoiceLanguage, VoiceGender);
            }
        }

        private void SpeechListen(string Text, decimal Rate, decimal Volume, string Language, string Gender)
        {
            string exceptedLanguage = string.Empty;
            VoiceGender exceptedGender = VoiceGender.Male;
            switch (Language)
            {
                case ("0"):
                    exceptedLanguage = "fr-FR";
                    break;
                case ("1"):
                    exceptedLanguage = "en-US";
                    break;
                case ("2"):
                    exceptedLanguage = "ja-JP";
                    break;
            }
            switch (Gender)
            {
                case ("0"):
                    exceptedGender = VoiceGender.Male;
                    break;
                case ("1"):
                    exceptedGender = VoiceGender.Female;
                    break;
            }
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.Rate = Decimal.ToInt32(Rate);
            speaker.SelectVoiceByHints(exceptedGender, VoiceAge.NotSet, 0, new CultureInfo(exceptedLanguage));
            speaker.Volume = Decimal.ToInt32(Volume);
            speaker.SpeakAsync(Text);
        }

        private void SpeechSave(string Text, decimal Rate, decimal Volume, string SaveLocation, string Language, string Gender)
        {
            string exceptedLanguage = string.Empty;
            VoiceGender exceptedGender = VoiceGender.Male;
            switch (Language)
            {
                case ("0"):
                    exceptedLanguage = "fr-FR";
                    break;
                case ("1"):
                    exceptedLanguage = "en-US";
                    break;
                case ("2"):
                    exceptedLanguage = "ja-JP";
                    break;
            }
            switch (Gender)
            {
                case ("0"):
                    exceptedGender = VoiceGender.Male;
                    break;
                case ("1"):
                    exceptedGender = VoiceGender.Female;
                    break;
            }
            speaker.Rate = Decimal.ToInt32(Rate);
            speaker.SelectVoiceByHints(exceptedGender, VoiceAge.NotSet, 0, new CultureInfo(exceptedLanguage));
            speaker.Volume = Decimal.ToInt32(Volume);
            speaker.SetOutputToWaveFile(SaveLocation);
            speaker.Speak(Text);
        }

        private void SpeechButton_Click(object sender, EventArgs e)
        {
            decimal RateListen = RateUpDown.Value;
            decimal VolumeListen = VolumeUpDown.Value;
            string TextListen = SpeechDialog.Text;
            string VoiceLanguage = LanguageVoice.SelectedIndex.ToString();
            string VoiceGender = GenderVoice.SelectedIndex.ToString();
            if (VoiceGender == "-1" || VoiceLanguage == "-1")
            {
                MessageBox.Show("Please select an language and a gender.");
                return;
            }
            SpeechListen(TextListen, RateListen, VolumeListen, VoiceLanguage, VoiceGender);
        }

        private void VolumeLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You found the secret!\nCodded by Shaffy 19/05/2019\n v2.0");
        }

        private void RateLabel_Click(object sender, EventArgs e)
        {
            VoiceTalkingd.Form2 f2 = new VoiceTalkingd.Form2();
            f2.ShowDialog();
        }
    }
}
