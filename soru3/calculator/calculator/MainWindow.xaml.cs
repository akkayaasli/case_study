using System;
using System.Collections.Generic;
using System.Linq;
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

namespace calculator
{

    public partial class MainWindow : Window
    {
        double ilkDeger, sonuc;
        SecilenFonksiyon secilenIslem;

       

        private void temizle(object gelenVeri, RoutedEventArgs e)
        {
            sonucLbl.Content = "0";
            ilkDeger = 0;
            sonuc = 0;
        }

   

        private void islem_Click(object gelenVeri, RoutedEventArgs e)
        {
        
            if (double.TryParse(sonucLbl.Content.ToString(), out ilkDeger))
            {
                sonucLbl.Content = "0";
            }
            if (gelenVeri == carpmaBtn)
                secilenIslem = SecilenFonksiyon.carpma;
            if (gelenVeri == bolmeBtn)
                secilenIslem = SecilenFonksiyon.bolme;
            if (gelenVeri == toplamaBtn)
                secilenIslem = SecilenFonksiyon.toplama;
            if (gelenVeri == cikarmaBtn)
                secilenIslem = SecilenFonksiyon.cikarma;

        }

        private void sayilar_click(object gelenVeri, RoutedEventArgs e)
        {
            int secilenDeger = 0;

     

                 if (gelenVeri == sifirBtn)
                     secilenDeger = 0; 
                 if (gelenVeri == birBtn)
                     secilenDeger = 1;
                 if (gelenVeri == ikiBtn)
                     secilenDeger = 2;
                 if (gelenVeri == ucBtn)
                     secilenDeger = 3;
                 if (gelenVeri == dortBtn)
                     secilenDeger = 4;
                 if (gelenVeri == besBtn)
                     secilenDeger = 5;
                 if (gelenVeri == altiBtn)
                     secilenDeger = 6;
                 if (gelenVeri == yediBtn)
                     secilenDeger = 7;
                 if (gelenVeri == sekizBtn)
                     secilenDeger = 8;
                 if (gelenVeri == dokuzBtn)
                     secilenDeger = 9;   

                if (sonucLbl.Content.ToString() == "0")
                {
                    sonucLbl.Content = secilenDeger;
                }
                else
                {
                    sonucLbl.Content = $"{sonucLbl.Content}{secilenDeger}";
                }


        }

        /*Bir dize gerçek bir araya yazmak için $ tanımlanır, sembolü başa eklenir.
         * Bir dize harfi ile $ başlıyorsa " arasında herhangi bir boşluk olamaz.*/

        private void esitBtn(object gelenVeri, RoutedEventArgs e)
        {
            double yeniDeger;
            if (double.TryParse(sonucLbl.Content.ToString(), out yeniDeger))
            {
                switch (secilenIslem)
                {
                    case SecilenFonksiyon.toplama:
                       sonuc= ilkDeger + yeniDeger;
                        break;

                    case SecilenFonksiyon.cikarma:
                        sonuc = ilkDeger - yeniDeger;
                        break;
                    case SecilenFonksiyon.carpma:
                        sonuc = ilkDeger * yeniDeger;
                        break;
                    case SecilenFonksiyon.bolme:
                        sonuc = ilkDeger / yeniDeger;
                        break;
                }
                sonucLbl.Content = sonuc.ToString();
                
            }
        }
        /* TryParse metodu geriye bool tipinde değer döndürmektedir. 
         * Eğer parametre olarak gönderilen değer dönüştürülmek istenilen 
         * değere dönüşürse out parametresi ile gönderilen parametreye sonucu aktarmaktadır. */

        public MainWindow()
        {
            InitializeComponent();
            btn_tm.Click += temizle;

        }

        enum SecilenFonksiyon
        {
            carpma,
            bolme,
            toplama,
            cikarma
            
        }


    }
}
