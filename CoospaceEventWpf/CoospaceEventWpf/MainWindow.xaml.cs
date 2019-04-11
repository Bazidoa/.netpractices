using CoospaceEventDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoospaceEventWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CoospaceDirectory MyCoospaceDirectory { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MyCoospaceDirectory = new CoospaceDirectory(500, 400);
            // feliratkozás
            MyCoospaceDirectory.ContentSizeAboveThreshold += Directory_ContentAboveThreshold;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!MyCoospaceDirectory.UploadContent(150))
                MessageBox.Show("Upload DID NOT succeed. The size of the file is too large.");
            Display.Content = $"Content uploaded to directory: {MyCoospaceDirectory.ContentSize}";
        }

        private void Directory_ContentAboveThreshold(object sender, ContentSizeAboveThresholdEventArgs e)
        {
            MessageBox.Show($"Almost full: {(double)e.CurrentContentSize / e.MaximumSize * 100: 0.00} %");
        }
    }
}
