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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Admin_Client_APL
{
    /// <summary>
    /// Logica di interazione per HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void onClick_Stats(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageStats());
        }

        private void onClick_Settings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageSettings());
        }
    }
}
