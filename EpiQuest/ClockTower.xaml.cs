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
using System.Threading;

namespace EpiQuest
{
    /// <summary>
    /// Interakční logika pro ClockTower.xaml
    /// </summary>
    public partial class ClockTower : Page
    {
        public ClockTower()
        {
            InitializeComponent();

        }


        private void CTNBT1_Click(object sender, RoutedEventArgs e)
        {
            TXT1.Visibility = Visibility.Hidden;
            TXT2.Visibility = Visibility.Visible;
        }
        private void CTNBT2_Click(object sender, RoutedEventArgs e)
        {
            TXT2.Visibility = Visibility.Hidden;
            TXT3.Visibility = Visibility.Visible;
        }
        private void CTNBT3_Click(object sender, RoutedEventArgs e)
        {
            //Začátek bitvy
        }
    }
}
