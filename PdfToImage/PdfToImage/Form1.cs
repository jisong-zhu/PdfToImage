using ImageMagick;
using System;
using System.IO;
using System.Windows.Forms;

namespace WordToJpg
{
    public partial class Word2JpgFrm : Form
    {
        private bool IsLoading = false;
        public Word2JpgFrm()
        {
            InitializeComponent();
            Executor.Touch();
        }
        private void Log(string msg)
        {
            Executor.ExecuteOnUI(() =>
            {
                LogTextBox.AppendText(msg + Environment.NewLine);
            }).Wait();
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            //OpenFileDialog打开窗口选择文件，这是微软的，直接调用就可以出微软选择文件的窗口 ，然后选择文件就ok了
            var dialog = new OpenFileDialog();
            //出界面，的方法
            dialog.ShowDialog();
            //在界面点击确定的时候出的一个文件地址。
            WordPathTextBox.Text = dialog.FileName;

        }

        private void SelectFoldBtn_Click(object sender, EventArgs e)
        {
            //OpenFileDialog打开窗口选择文件，这是微软的，直接调用就可以出微软选择文件的窗口 ，然后选择文件就ok了
            var dialog = new FolderBrowserDialog();
            //出界面，的方法
            dialog.ShowDialog();
            //在界面点击确定的时候出的一个文件地址。
            ImageFolderTextBox.Text = dialog.SelectedPath;
        }
        private void ToggleButton(bool isLoading)
        {
            IsLoading = isLoading;
            Executor.ExecuteOnUI(() =>
            {
                if (!isLoading)
                {
                    ConvertBtn.ForeColor = System.Drawing.Color.White;
                    ConvertBtn.BackColor = System.Drawing.Color.DodgerBlue;
                }
                else
                {
                    ConvertBtn.ForeColor = System.Drawing.Color.Gray;
                    ConvertBtn.BackColor = System.Drawing.Color.Silver;
                }
            });
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if (IsLoading)
            {
                return;
            }
            PDF2Jpg(WordPathTextBox.Text, ImageFolderTextBox.Text);

        }
        public void PDF2Jpg(string srcPdfPath, string desPicPath)
        {
            Log($"【开始转换文件】{srcPdfPath}");
            Executor.ExecuteOnBackground(() =>
            {
                try
                {
                    ToggleButton(true);
                    using (var images = new MagickImageCollection())
                    {
                        var settings = new MagickReadSettings();
                        settings.Density = new Density(300, 300);
                        Log($"【正在读取文件】{srcPdfPath}");
                        images.Read(srcPdfPath, settings);
                        var pngCount = images.Count;
                        Log($"【读取文件完成】共识别到 {pngCount} 页");
                        var i = 1;
                        foreach (var image in images)
                        {
                            Log($"【正在处理】第 {i}/{pngCount} 页");
                            image.Format = MagickFormat.Jpeg;
                            image.Alpha(AlphaOption.Remove);
                            image.Write(Path.Combine(desPicPath, $"{i}.jpg"));
                            i++;
                        }
                    }

                    Log($"【处理完成】图片保存在：{desPicPath}");
                    MessageBox.Show($"转换成功。", "提示框", MessageBoxButtons.OK);
                }
                catch (Exception e)
                {
                    Log($"处理失败");
                    MessageBox.Show($"转换失败了。", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    ToggleButton(false);
                }
            });
        }
    }
}
