using RDA.Task._1.Core;
using RDA.Task._1.View.Pages;
using System.Windows;
using System.Windows.Controls;

namespace RDA.Task._1.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());

        }
    }
}
