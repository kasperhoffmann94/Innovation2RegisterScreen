﻿using System;
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
    /// Interaction logic for RegisterByEmail.xaml
    /// </summary>
    public partial class RegisterByEmail : Window
    {
        MainWindow mainWindow = new MainWindow();
        public RegisterByEmail()
        {
            InitializeComponent();
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }
    }
}
