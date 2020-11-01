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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            txtBl.Background = new SolidColorBrush(Colors.Blue);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            txtBl.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            txtBl.Background = new SolidColorBrush(Colors.Orange);
        }
    }
}
