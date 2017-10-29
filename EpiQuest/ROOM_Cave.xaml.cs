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
    /// Interakční logika pro ROOM_Cave.xaml
    /// </summary>
    public partial class ROOM_Cave : Page
    {

        public int HP_Bojovnik1 = 80;
        public int HP_Tezkoodenec1 = 100;
        public int HP_Lupic1 = 60;

        public ROOM_Cave()
        {
            InitializeComponent();

            SkrytUtoky();

            //Bojovnik1();
            //Tezkoodenec1();
            //Lupic1();
        }
        public void SkrytUtoky()
        {
            Silny_utok.Visibility = Visibility.Hidden;
            Rychly_utok.Visibility = Visibility.Hidden;
            Normalni_utok.Visibility = Visibility.Hidden;
        }

        public int NahodnaClassa() {
            Random Typ = new Random();
            int Typ_Nepritele = Typ.Next(1, 4);
            return Typ_Nepritele;
        }

        public void Bojovnik1()
        {
            Random Bojovnik_HitChance1 = new Random(); // Normální útok -> 55% Chance, 14-19 DMG
            Random Bojovnik_DMG1 = new Random();
            int HitChance_Bojovnik1 = Bojovnik_HitChance1.Next(1, 101);
            int DMG_Bojovnik1 = Bojovnik_DMG1.Next(14, 20);

            if (HitChance_Bojovnik1 >= 55)
            {
                //Zasah za DMG_Bojovnik
                if(int.TryParse(CurrentHP.Content.ToString(), out int Thief_HP))
                {
                    Thief_HP -= DMG_Bojovnik1;
                    CurrentHP.Content = Thief_HP;
                    DMGInfo_Thief.Content = DMG_Bojovnik1;
                }
            }
            else
            {
                //Vedle
                DMGInfo_Thief.Content = "Vedle";
            }

            if (HP_Bojovnik1 <= 0)
            {

            }
        }

        public void Tezkoodenec1()
        {
            Random Tezkoodenec_HitChance1 = new Random(); // Normální útok -> 55% Chance, 14-19 DMG
            Random Tezkoodenec_DMG1 = new Random();
            int HitChance_Tezkoodenec1 = Tezkoodenec_HitChance1.Next(1, 101);
            int DMG_Tezkoodenec1 = Tezkoodenec_DMG1.Next(25, 31);

            if (HitChance_Tezkoodenec1 >= 30)
            {
                //Zasah za DMG_Tezkoodenec
                if (int.TryParse(CurrentHP.Content.ToString(), out int Thief_HP))
                {
                    Thief_HP -= DMG_Tezkoodenec1;
                    CurrentHP.Content = Thief_HP;
                    DMGInfo_Thief.Content = DMG_Tezkoodenec1;
                }
            }
            else
            {
                //Vedle
                DMGInfo_Thief.Content = "Vedle";
            }

        }

        public void Lupic1()
        {
            Random Lupic_HitChance1 = new Random(); // Normální útok -> 55% Chance, 14-19 DMG
            Random Lupic_DMG1 = new Random();
            int HitChance_Lupic1 = Lupic_HitChance1.Next(1, 101);
            int DMG_Lupic1 = Lupic_DMG1.Next(8, 14);

            if (HitChance_Lupic1 >= 1)
            {
                //Zasah za DMG_Lupic
                if (int.TryParse(CurrentHP.Content.ToString(), out int Thief_HP))
                {
                    Thief_HP -= DMG_Lupic1;
                    CurrentHP.Content = Thief_HP;
                    DMGInfo_Thief.Content = DMG_Lupic1;
                }
            }
            else
            {
                //Vedle
                DMGInfo_Thief.Content = "Vedle";
            }

        }
    }



}
