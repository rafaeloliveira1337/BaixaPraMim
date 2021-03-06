using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
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
            // videoUrl = "https://www.youtube.com/watch?v=MDpecrGsHKM";
            
            if (!isValidUrl(videoUrl))
            {
                MessageBox.Show("O campo \"URL do vídeo\" não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mediaTypeRb = groupBox_downloadType.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            
            if (downloadMedia(videoUrl, mediaTypeRb.Name))
            {
                MessageBox.Show("Processo concluído, verifique a área de trabalho.", "Pronto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            input_videoUrl.Text = "";
        }

        private bool isValidUrl(string url)
        {
            return url.Trim().Length > 0;
        }

        private bool downloadMedia(string videoUrl, string mediaType)
        {
            Cursor = Cursors.WaitCursor;

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

            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var youtubeDlExecutable = Path.Combine(roamingDirectory, "BaixaPraMim\\youtube-dl.exe");

            var processInfo = new ProcessStartInfo(youtubeDlExecutable, command);
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            var process = Process.Start(processInfo);

            string err = process.StandardError.ReadToEnd();
            if (err.Length > 0)
            {
                MessageBox.Show("Ocorreu um erro ao tentar baixar o item, verifique a conexão com a internet, a URL do vídeo, e tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Arrow;    
                return false;
            }
            
            process.WaitForExit();

            Cursor = Cursors.Arrow;
            return true;
        }

        private void form_BaixaPraMim_Load(object sender, EventArgs e)
        {
            checkRequirements();
        }

        private void checkRequirements()
        {
            // this will return System32 folder on 32-bit systems and SysWOW64 folder in 64-bit systems
            var systemDirectory = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);

            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appFolder = Path.Combine(roamingDirectory, "BaixaPraMim");
            var presetsFolder = Path.Combine(appFolder, "presets");

            // create required folders, if they don't already exist
            Directory.CreateDirectory(presetsFolder);

            // check this file separately because it's the only one that's not a byte array
            if (!File.Exists(presetsFolder + "\\ffprobe.xsd"))
            {
                File.WriteAllText(presetsFolder + "\\ffprobe.xsd", Properties.Resources.ffprobe_xsd);
            }

            Dictionary<string, byte[]> fileMap = new Dictionary<string, byte[]>();
            fileMap.Add(appFolder + "\\youtube-dl.exe", Properties.Resources.youtube_dl);
            fileMap.Add(appFolder + "\\ffmpeg.exe", Properties.Resources.ffmpeg);
            fileMap.Add(appFolder + "\\ffplay.exe", Properties.Resources.ffplay);
            fileMap.Add(appFolder + "\\ffprobe.exe", Properties.Resources.ffprobe);
            fileMap.Add(presetsFolder + "\\libvpx-1080p.ffpreset", Properties.Resources.libvpx_1080p);
            fileMap.Add(presetsFolder + "\\libvpx-1080p50_60.ffpreset", Properties.Resources.libvpx_1080p50_60);
            fileMap.Add(presetsFolder + "\\libvpx-360p.ffpreset", Properties.Resources.libvpx_360p);
            fileMap.Add(presetsFolder + "\\libvpx-720p.ffpreset", Properties.Resources.libvpx_720p);
            fileMap.Add(presetsFolder + "\\libvpx-720p50_60.ffpreset", Properties.Resources.libvpx_720p50_60);
            
            // TODO: see if we can get around the permission issue when writing to system folder,
            // otherwise just leave the dll file in the user's doc folder and show a message saying 
            // that the user needs to copy the file to System folder for the program to work.
            //fileMap.Add(systemDirectory + "\\msvcr100.dll", Properties.Resources.msvcr100);
            
            // only copy files that don't already exist on destination
            foreach (KeyValuePair<string, byte[]> entry in fileMap)
            {
                if (!File.Exists(entry.Key))
                {
                    File.WriteAllBytes(entry.Key, entry.Value);
                }
            }
        }
    }
}
