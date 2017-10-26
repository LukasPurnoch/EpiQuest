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

namespace EpiQuest
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void NovaHra(object sender, RoutedEventArgs e)
        {
            MENU.Content = new ClockTower();
        }

        private void NacistHru(object sender, RoutedEventArgs e)
        {
            //Zde bude prozatimne bitva pro ucely testovani
        }

        private void UkoncitHru(object sender, RoutedEventArgs e)
        {

        }
    }
}
