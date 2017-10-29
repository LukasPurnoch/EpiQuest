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
        public int HP_Bojovnik2 = 80;
        public int HP_Tezkoodenec2 = 100;
        public int HP_Lupic2 = 60;

        public int EnemySelect = 0;


        public ROOM_Cave()
        {
            InitializeComponent();

            SkrytUtoky();

            
        }

        public void SkrytUtoky()
        {
            Silny_utok.Visibility = Visibility.Hidden;
            Rychly_utok.Visibility = Visibility.Hidden;
            Normalni_utok.Visibility = Visibility.Hidden;
        }
        public void ZobrazitUtoky()
        {
            Silny_utok.Visibility = Visibility.Visible;
            Rychly_utok.Visibility = Visibility.Visible;
            Normalni_utok.Visibility = Visibility.Visible;
        }

        public int NahodnaClassa() {
            Random Typ = new Random();
            int Typ_Nepritele = Typ.Next(1, 4);
            return Typ_Nepritele;
        }

        public void RychlyUtok1()
        {
            Random RychlyUtok1_HitChance = new Random(); // Rychlý útok -> 80% Chance, 8-13 DMG
            Random RychlyUtok1_DMG = new Random();
            int HitChance_RychlyUtok1 = RychlyUtok1_HitChance.Next(1, 101);
            int DMG_RychlyUtok1 = RychlyUtok1_DMG.Next(8, 14);

            if (HitChance_RychlyUtok1 <= 80)
            {
                //Zasah za DMG_RychlyUtok
                if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out int ENM1_HP))
                {
                    ENM1_HP -= DMG_RychlyUtok1;
                    CurrentHPEnemy1.Content = ENM1_HP;
                    DMGInfo_Pos1.Content = DMG_RychlyUtok1;

                    HP_Bojovnik1 -= DMG_RychlyUtok1;
                    HP_Tezkoodenec1 -= DMG_RychlyUtok1;
                    HP_Lupic1 -= DMG_RychlyUtok1;
                }
            }
            else
            {
                DMGInfo_Pos1.Content = "Vedle";
            }

            
        }
        public void RychlyUtok2()
        {
            Random RychlyUtok2_HitChance = new Random(); // Rychlý útok -> 80% Chance, 8-13 DMG
            Random RychlyUtok2_DMG = new Random();
            int HitChance_RychlyUtok2 = RychlyUtok2_HitChance.Next(1, 101);
            int DMG_RychlyUtok2 = RychlyUtok2_DMG.Next(8, 14);

            if (HitChance_RychlyUtok2 <= 80)
            {
                //Zasah za DMG_RychlyUtok
                if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out int ENM2_HP))
                {
                    ENM2_HP -= DMG_RychlyUtok2;
                    CurrentHPEnemy2.Content = ENM2_HP;
                    DMGInfo_Pos2.Content = DMG_RychlyUtok2;

                    HP_Bojovnik2 -= DMG_RychlyUtok2;
                    HP_Tezkoodenec2 -= DMG_RychlyUtok2;
                    HP_Lupic2 -= DMG_RychlyUtok2;
                }
            }
            else
            {
                DMGInfo_Pos2.Content = "Vedle";
            }


        }
        public void SilnyUtok1()
        {
            Random SilnyUtok1_HitChance = new Random(); // Silný útok -> 30% Chance, 25-30 DMG
            Random SilnyUtok1_DMG = new Random();
            int HitChance_SilnyUtok1 = SilnyUtok1_HitChance.Next(1, 101);
            int DMG_SilnyUtok1 = SilnyUtok1_DMG.Next(25, 31);

            if (HitChance_SilnyUtok1 <= 30)
            {
                //Zasah za DMG_SilnyUtok
                if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out int ENM1_HP))
                {
                    ENM1_HP -= DMG_SilnyUtok1;
                    CurrentHPEnemy1.Content = ENM1_HP;
                    DMGInfo_Pos1.Content = DMG_SilnyUtok1;

                    HP_Bojovnik1 -= DMG_SilnyUtok1;
                    HP_Tezkoodenec1 -= DMG_SilnyUtok1;
                    HP_Lupic1 -= DMG_SilnyUtok1;
                }
            }
            else
            {
                DMGInfo_Pos1.Content = "Vedle";
            }
        }
        public void SilnyUtok2()
        {
            Random SilnyUtok2_HitChance = new Random(); // Silný útok -> 30% Chance, 25-30 DMG
            Random SilnyUtok2_DMG = new Random();
            int HitChance_SilnyUtok2 = SilnyUtok2_HitChance.Next(1, 101);
            int DMG_SilnyUtok2 = SilnyUtok2_DMG.Next(25, 31);

            if (HitChance_SilnyUtok2 <= 30)
            {
                //Zasah za DMG_SilnyUtok
                if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out int ENM2_HP))
                {
                    ENM2_HP -= DMG_SilnyUtok2;
                    CurrentHPEnemy2.Content = ENM2_HP;
                    DMGInfo_Pos2.Content = DMG_SilnyUtok2;

                    HP_Bojovnik2 -= DMG_SilnyUtok2;
                    HP_Tezkoodenec2 -= DMG_SilnyUtok2;
                    HP_Lupic2 -= DMG_SilnyUtok2;
                }
            }
            else
            {
                DMGInfo_Pos2.Content = "Vedle";
            }
        }
        public void NormalniUtok1()
        {
            Random NormalniUtok1_HitChance = new Random(); // Normální útok -> 855% Chance, 14-19 DMG
            Random NormalniUtok1_DMG = new Random();
            int HitChance_NormalniUtok1 = NormalniUtok1_HitChance.Next(1, 101);
            int DMG_NormalniUtok1 = NormalniUtok1_DMG.Next(14, 20);

            if (HitChance_NormalniUtok1 <= 55)
            {
                //Zasah za DMG_NormalniUtok1
                if (int.TryParse(CurrentHPEnemy1.Content.ToString(), out int ENM1_HP))
                {
                    ENM1_HP -= DMG_NormalniUtok1;
                    CurrentHPEnemy1.Content = ENM1_HP;
                    DMGInfo_Pos1.Content = DMG_NormalniUtok1;

                    HP_Bojovnik1 -= DMG_NormalniUtok1;
                    HP_Tezkoodenec1 -= DMG_NormalniUtok1;
                    HP_Lupic1 -= DMG_NormalniUtok1;
                }
            }
            else
            {
                DMGInfo_Pos1.Content = "Vedle";
            }
        }
        public void NormalniUtok2()
        {
            Random NormalniUtok2_HitChance = new Random(); // Normální útok -> 855% Chance, 14-19 DMG
            Random NormalniUtok2_DMG = new Random();
            int HitChance_NormalniUtok2 = NormalniUtok2_HitChance.Next(1, 101);
            int DMG_NormalniUtok2 = NormalniUtok2_DMG.Next(14, 20);

            if (HitChance_NormalniUtok2 <= 55)
            {
                //Zasah za DMG_NormalniUtok1
                if (int.TryParse(CurrentHPEnemy2.Content.ToString(), out int ENM2_HP))
                {
                    ENM2_HP -= DMG_NormalniUtok2;
                    CurrentHPEnemy2.Content = ENM2_HP;
                    DMGInfo_Pos2.Content = DMG_NormalniUtok2;

                    HP_Bojovnik2 -= DMG_NormalniUtok2;
                    HP_Tezkoodenec2 -= DMG_NormalniUtok2;
                    HP_Lupic2 -= DMG_NormalniUtok2;
                }
            }
            else
            {
                DMGInfo_Pos2.Content = "Vedle";
            }
        }

        public void Bojovnik1()
        {
            Random Bojovnik_HitChance1 = new Random(); // Normální útok -> 55% Chance, 14-19 DMG
            Random Bojovnik_DMG1 = new Random();
            int HitChance_Bojovnik1 = Bojovnik_HitChance1.Next(1, 101);
            int DMG_Bojovnik1 = Bojovnik_DMG1.Next(14, 20);


            if (HP_Bojovnik1 > 0)
            {
                if (HitChance_Bojovnik1 <= 55)
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
            }
            if (HP_Bojovnik1 <= 0)
            {
                Enemy1.Visibility = Visibility.Hidden;
                EnemyPositionM1.Visibility = Visibility.Hidden;
                CurrentHPEnemy1.Visibility = Visibility.Hidden;
                MaxHPEnemy1.Visibility = Visibility.Hidden;
                Enemy1Attack.Visibility = Visibility.Hidden;
            }
        }
        public void Tezkoodenec1()
        {
            Random Tezkoodenec_HitChance1 = new Random(); // Silný útok -> 30% Chance, 25-30 DMG
            Random Tezkoodenec_DMG1 = new Random();
            int HitChance_Tezkoodenec1 = Tezkoodenec_HitChance1.Next(1, 101);
            int DMG_Tezkoodenec1 = Tezkoodenec_DMG1.Next(25, 31);

            if (HP_Tezkoodenec1 > 0)
            {
                if (HitChance_Tezkoodenec1 <= 30)
                {
                    //Zasah za DMG_Bojovnik
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
            if (HP_Tezkoodenec1 <= 0)
            {
                Enemy1.Visibility = Visibility.Hidden;
                EnemyPositionM1.Visibility = Visibility.Hidden;
                CurrentHPEnemy1.Visibility = Visibility.Hidden;
                MaxHPEnemy1.Visibility = Visibility.Hidden;
                Enemy1Attack.Visibility = Visibility.Hidden;
            }

        }
        public void Lupic1()
        {
            Random Lupic_HitChance1 = new Random(); // Rychlý útok -> 80% Chance, 8-13 DMG
            Random Lupic_DMG1 = new Random();
            int HitChance_Lupic1 = Lupic_HitChance1.Next(1, 101);
            int DMG_Lupic1 = Lupic_DMG1.Next(8, 14);

            if (HP_Lupic1 > 0)
            {
                if (HitChance_Lupic1 <= 80)
                {
                    //Zasah za DMG_Bojovnik
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
            if (HP_Lupic1 <= 0)
            {
                Enemy1.Visibility = Visibility.Hidden;
                EnemyPositionM1.Visibility = Visibility.Hidden;
                CurrentHPEnemy1.Visibility = Visibility.Hidden;
                MaxHPEnemy1.Visibility = Visibility.Hidden;
                Enemy1Attack.Visibility = Visibility.Hidden;
            }

        }

        private void Enemy1Attack_Click(object sender, RoutedEventArgs e)
        {
            EnemySelect = 1;
            ZobrazitUtoky();
        }
        private void Enemy2Attack_Click(object sender, RoutedEventArgs e)
        {
            EnemySelect = 2;
            ZobrazitUtoky();
        }

        private void Rychly_utok_Click(object sender, RoutedEventArgs e)
        {
            if (EnemySelect == 1)
            {
                RychlyUtok1();
                Lupic1();
            }
            else
            {
                //RychlyUtok2();
            }
        }
        private void Silny_utok_Click(object sender, RoutedEventArgs e)
        {
            if (EnemySelect == 1)
            {
                SilnyUtok1();
                Lupic1();
            }
            else
            {
                //SilnyUtok2();
            }
        }
        private void Normalni_utok_Click(object sender, RoutedEventArgs e)
        {
            if (EnemySelect == 1)
            {
                NormalniUtok1();
                Lupic1();
            }
            else
            {
                //NormalniUtok2();
            }
        }
    }
}
