using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using YoutubeExtractor;

namespace Wizzify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox textBox = new TextBox();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            YoutubeDownloader yd = new YoutubeDownloader("AIzaSyBfYlF0okbWlWRhrDBBxrzdQgNtF4Bd3P0");
            string videoname = textBox.Text;
            try
            {
                yd.Search(videoname);
            }
            catch (Exception err) {
                MessageBox.Show("Error:\n" + err.Message);
            }
            
        }
    }
}
