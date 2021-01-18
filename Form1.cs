using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BaixaPraMim
{
    public partial class form_BaixaPraMim : Form
    {
        public form_BaixaPraMim()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string videoUrl = input_videoUrl.Text;
            videoUrl = "https://www.youtube.com/watch?v=MDpecrGsHKM";
            
            if (!isValidUrl(videoUrl))
            {
                System.Windows.Forms.MessageBox.Show("O campo \"URL do vídeo\" não pode estar vazio!", "Erro");
                return;
            }

            var mediaTypeRb = groupBox_downloadType.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            if (downloadMedia(videoUrl, mediaTypeRb.Name))
            {
                System.Windows.Forms.MessageBox.Show("Processo concluído, verifique a área de trabalho.", "Pronto!");
            }
            
            input_videoUrl.Text = "";
        }

        private bool isValidUrl(string url)
        {
            return url.Trim().Length > 0;
        }

        private bool downloadMedia(string videoUrl, string mediaType)
        {
            string destinationFormating;
            switch (mediaType)
            {
                case "rb_video":
                    destinationFormating = "-f mp4";
                    break;
                default:
                    destinationFormating = "--extract-audio --audio-format mp3";
                    break;
            }

            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string command = destinationFormating + " -o \"" + pathToDesktop + "\\%(title)s.%(ext)s\" " + videoUrl;

            var processInfo = new ProcessStartInfo("youtube-dl.exe", command);
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            var process = Process.Start(processInfo);

            string err = process.StandardError.ReadToEnd();
            if (err.Length > 0)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao tentar baixar o item, verifique a conexão com a internet, a URL do vídeo, e tente novamente mais tarde.", "Erro");
                return false;
            }

            process.WaitForExit();
            return true;
        }
    }
}
