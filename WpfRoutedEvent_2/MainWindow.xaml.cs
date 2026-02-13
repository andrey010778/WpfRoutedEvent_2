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

namespace WpfRoutedEvent_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Click_1(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;

            if (!double.TryParse(txtBox.Text, out double a))
            {
                MessageBox.Show("Input correct number!");
                return;
            }

            switch (feSource.Name)
            {
                case "butAdd":
                    a += a;
                    break;

                case "butMult":
                    a *= a;
                    break;
            }

            e.Handled = true;
            txtBox.Text = string.Format("{0:#.##}", a);
        }
    }
}