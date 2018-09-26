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

namespace HexEncodingWithUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            var src = OriginText.Text;
            if (!string.IsNullOrEmpty(src))
            {
                var ret = SimpleEncoding.UTF8ToHex(src);
                CipherText.Text = ret;
            }
        }

        private void BtnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            var src = CipherText.Text;
            if (!string.IsNullOrEmpty(src))
            {
                var ret = SimpleEncoding.HexToUTF8(src);
                OriginText.Text = ret;
            }
        }
    }
}
