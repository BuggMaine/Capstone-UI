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

namespace Capstone_UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GameSelection());
        }
    }
}