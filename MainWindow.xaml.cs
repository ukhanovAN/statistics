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

namespace gitt
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

        private void button_Rusanovskaya_Click(object sender, RoutedEventArgs e)
        {
            Rusanovskaya rusanovskaya = new Rusanovskaya();
            rusanovskaya.Show();
        }

        private void button_Karkina_Click_1(object sender, RoutedEventArgs e)
        {
            Karkina karkina = new Karkina();
            karkina.Show();
        }

        private void button_Uhanova_Click_1(object sender, RoutedEventArgs e)
        {
            Uhanova khan = new Uhanova();
            khan.Show();
        }
    }
}
