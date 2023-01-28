using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Exception = System.Exception;

namespace Transparentify
{
    public partial class Transparentify : Form
    {
        public Transparentify()
        {
            InitializeComponent();
        }

        private void commandBrowseFolder_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                inputDestinationFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void commandBrowseSource_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                inputSourceFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void commandExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.inputSourceFolder.Text.Trim()))
            {
                MessageBox.Show("Image folder is empty");
                return;
            }

            var pngImageCollection = new List<string>();
            ReadFiles(this.inputSourceFolder.Text, pngImageCollection);

            ProcessImages(pngImageCollection, this.inputSourceFolder.Text.Trim(), this.inputDestinationFolder.Text.Trim(),
                this.inputPrefix.Text.Trim(), this.inputSuffix.Text.Trim());

            MessageBox.Show("Complete");
        }

        private static void ReadFiles(string folder, List<string> pngImageCollection)
        {
            // Get all files in the current folder
            var files = Directory.GetFiles(folder);
            var pngImages = files.Any()
                ? files.Where(x => Path.GetExtension(x)?.ToLower() == ".png").ToList()
                : new List<string>();

            if (pngImages.Any())
            {
                pngImageCollection.AddRange(pngImages);
            }

            // Get all sub-folders in the current folder
            var subfolders = Directory.GetDirectories(folder);
            foreach (var subfolder in subfolders)
            {
                // Recursively call this method for each sub-folder
                ReadFiles(subfolder, pngImageCollection);
            }
        }

        private static void ProcessImages(List<string> pngImageCollection, string source, string destination, string prefix, string suffix)
        {
            if (string.IsNullOrEmpty(destination))
            {
                destination = source;
            }

            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            foreach (var file in pngImageCollection)
            {
                try
                {
                    var image = new Bitmap(file);

                    for (var x = 0; x < image.Width; x++)
                    {
                        for (var y = 0; y < image.Height; y++)
                        {
                            var pixelColor = image.GetPixel(x, y);

                            if (pixelColor.R == 255 && pixelColor.G == 255 && pixelColor.B == 255)
                            {
                                image.SetPixel(x, y, Color.Transparent);
                            }
                        }
                    }

                    var newFileName = Path.GetFileName(file);
                    if (!string.IsNullOrEmpty(prefix))
                    {
                        newFileName = $"{prefix}{newFileName}";
                    }

                    if (!string.IsNullOrEmpty(suffix))
                    {
                        var ext = Path.GetExtension(file);
                        newFileName = Path.GetFileNameWithoutExtension(newFileName);
                        newFileName = $"{newFileName}{suffix}{ext}";
                    }

                    var subFolder = file.Replace(source, string.Empty).Replace(Path.GetFileName(file), string.Empty);
                    if ((!string.IsNullOrEmpty(subFolder) || subFolder != "\\") && !Directory.Exists(subFolder))
                    {
                        Directory.CreateDirectory(subFolder);
                    }

                    var fullNewPath = $"{destination}\\{newFileName}";
                    if (!string.IsNullOrEmpty(subFolder) && subFolder != "\\")
                    {
                        fullNewPath = $"{destination}\\{subFolder}\\{newFileName}";
                    }

                    image.Save(fullNewPath, ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    File.AppendAllText("Log", $"{DateTime.Now:O}\t{ex.Message}{Environment.NewLine}");
                }
            }
        }
    }
}
