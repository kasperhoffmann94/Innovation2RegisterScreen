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

namespace Innovation2ReturnJacket
{
    /// <summary>
    /// Interaction logic for ReturnJacketWindow.xaml
    /// </summary>
    public partial class ReturnJacketWindow : Window
    {
        public ReturnJacketWindow()
        {
            InitializeComponent();
            Random random = new Random();
            int randomNumber = random.Next(0, 200);
            NumberLabel.Content = randomNumber;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
