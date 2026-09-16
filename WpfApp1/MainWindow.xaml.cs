using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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
        private void egth_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(numberTextBox.Text);
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    result += $"{i}*{j}={i * j}\t";
                }
                result += "\n";
            }
            resultTextBlock.Text = result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTexBox.Text.Trim();
            string phone = telTextBox.Text.Trim();
            string message = $"【使用者資訊】\n姓名：{name}\n電話：{phone}";
            MessageBox.Show(message, "使用者資訊確認", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}