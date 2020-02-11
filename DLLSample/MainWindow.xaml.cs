using libNakuYun;
using libNakuYun.Print;
using System;
using System.Windows;

namespace DLLSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseFile(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                PathText.Text = openFileDialog.FileName;
            }
        }

        private void Print(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(PathText.Text))
            {
                return;
            }
            var filePath = PathText.Text;

            var preference = new PrintPreference
            {
                copy = 1,
                paperKind = PrintPreference.PaperKind.A4,
                side = PrintPreference.Side.OneSide
            };
            var task = new PrintTask(filePath, preference);
            var result = NakuYun.Invoke(task);

            ResultText.Text = result;

        }
    }
}
