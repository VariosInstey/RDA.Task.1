﻿using RDA.Task._1.Core;
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

namespace RDA.Task._1.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }
        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double h = Convert.ToDouble(TbH.Text);

                MessageBox.Show($"P = {(Math.Exp(y + 2.5) + 7.1 * Math.Pow(h, 3)) / (Math.Log10(Math.Sqrt(y + 0.04 * h)))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbH.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
