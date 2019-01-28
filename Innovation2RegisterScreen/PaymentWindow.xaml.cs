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
using System.Windows.Shapes;

namespace Innovation2RegisterScreen
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {

        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
            Pay pay = new Pay();
            pay.Show(); 
            this.Close();
        }

        private void PayBtnAPp_Click(object sender, RoutedEventArgs e)
        {
            PayApp payApp = new PayApp();
            payApp.Show();
            this.Close();
        }
    }
}
