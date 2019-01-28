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
    /// Interaction logic for PayApp.xaml
    /// </summary>
    public partial class PayApp : Window
    {
        public PayApp()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            PaymentWindow payement = new PaymentWindow();
            payement.Show();
            this.Close();
        }
    }
}
