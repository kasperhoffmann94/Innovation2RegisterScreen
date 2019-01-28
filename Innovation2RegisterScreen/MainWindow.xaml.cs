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

namespace Innovation2RegisterScreen
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

        private void RegisterJacketBtn(object sender, RoutedEventArgs e)
        {
            PaymentWindow payment = new PaymentWindow();
            payment.Show();
            this.Close();
        }

        private void RegisterJacketAppBtn(object sender, RoutedEventArgs e)
        {
            PaymentWindowApp payment = new PaymentWindowApp();
            payment.Show();
            this.Close();
        }
    }
}
