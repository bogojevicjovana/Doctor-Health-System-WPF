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

namespace ProjekatWpfHci
{
    /// <summary>
    /// Interaction logic for Rasspored.xaml
    /// </summary>
    public partial class Rasspored : Window
    {
        public Rasspored()
        {
            InitializeComponent();
        }

        private void Calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Ras.NavigationService.Navigate(new Uri("RasporedPage.xaml", UriKind.Relative));
        }
    }
}
