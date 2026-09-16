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
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTexBox.Text;
            string telphone = telTextBox.Text;
            string message = $"Name: {name}\nTelphone:{telphone}";
            MessageBox.Show(message, "我的資訊", MessageBoxButton.OK);
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
    }
}