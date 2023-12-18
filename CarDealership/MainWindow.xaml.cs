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

namespace CarDealership
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Buyer page = new Buyer();
            Frame.Content = page;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CarBrand page = new CarBrand();
            Frame.Content = page;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Employee page = new Employee();
            Frame.Content = page;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Car page = new Car();
            Frame.Content = page;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Sales page = new Sales();
            Frame.Content = page;
        }
    }
}
