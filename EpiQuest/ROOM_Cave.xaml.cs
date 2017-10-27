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

    class Enemy
    {
        public int NahodnaClassa() // Return Typ_Nepritele
        {
            Random Typ = new Random();
            int Typ_Nepritele = Typ.Next(1,4);
            return Typ_Nepritele;
        }

        public void Bojovnik()
        {
            int HP = 80;


            Random Bojovnik_HitChance = new Random(); // Normální útok -> 55% Chance, 14-19 DMG
            Random Bojovnik_DMG = new Random();
            int HitChance_Bojovnik = Bojovnik_HitChance.Next(1,101);
            int DMG_Bojovnik = Bojovnik_DMG.Next(14,20);

            if (HitChance_Bojovnik >= 55)
            {
                //Zasah za DMG_Bojovnik

                
                //int.TryParse(Y, out int y);
            }
            else
            {
                //Vedle
            }

        }
    }

    /// <summary>
    /// Interakční logika pro ROOM_Cave.xaml
    /// </summary>
    public partial class ROOM_Cave : Page
    {
        public ROOM_Cave()
        {
            InitializeComponent();
        }
    }



}
