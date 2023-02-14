using RDA.Task._1.View;
using System.Windows;

namespace RDA.Task._1
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}