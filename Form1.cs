using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace çarkıfelek
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        public int harfSayisi;
        public int puan = 0;
        //public int sayaç = 0;
        //public int sayaç2 = 0;
        //public int a;
        Random rnd = new Random();
        //string[] sayi = { "100", "200", "300", "1000", "250", "500", "600", "0", "2000" };

        #endregion

        #region Fonsiyonlar

        private void HarfleriKapat()
        {
            Btn_A.Visible = false;
            Btn_B.Visible = false;
            Btn_C.Visible = false;
            Btn_Ç.Visible = false;
            Btn_D.Visible = false;
            Btn_E.Visible = false;
            Btn_F.Visible = false;
            Btn_G.Visible = false;
            Btn_Ğ.Visible = false;
            Btn_H.Visible = false;
            Btn_I.Visible = false;
            Btn_İ.Visible = false;
            Btn_J.Visible = false;
            Btn_K.Visible = false;
            Btn_L.Visible = false;
            Btn_M.Visible = false;
            Btn_N.Visible = false;
            Btn_O.Visible = false;
            Btn_Ö.Visible = false;
            Btn_P.Visible = false;
            Btn_R.Visible = false;
            Btn_S.Visible = false;
            Btn_Ş.Visible = false;
            Btn_T.Visible = false;
            Btn_U.Visible = false;
            Btn_Ü.Visible = false;
            Btn_V.Visible = false;
            Btn_Y.Visible = false;
            Btn_Z.Visible = false;
        }

        private void HarfleriAc()
        {
            Btn_A.Visible = true;
            Btn_B.Visible = true;
            Btn_C.Visible = true;
            Btn_Ç.Visible = true;
            Btn_D.Visible = true;
            Btn_E.Visible = true;
            Btn_F.Visible = true;
            Btn_G.Visible = true;
            Btn_Ğ.Visible = true;
            Btn_H.Visible = true;
            Btn_I.Visible = true;
            Btn_İ.Visible = true;
            Btn_J.Visible = true;
            Btn_K.Visible = true;
            Btn_L.Visible = true;
            Btn_M.Visible = true;
            Btn_N.Visible = true;
            Btn_O.Visible = true;
            Btn_Ö.Visible = true;
            Btn_P.Visible = true;
            Btn_R.Visible = true;
            Btn_S.Visible = true;
            Btn_Ş.Visible = true;
            Btn_T.Visible = true;
            Btn_U.Visible = true;
            Btn_Ü.Visible = true;
            Btn_V.Visible = true;
            Btn_Y.Visible = true;
            Btn_Z.Visible = true;
        }

        private void SoruHarfleriKapat()
        {
            Btn_Soru1.Visible = false;
            Btn_Soru2.Visible = false;
            Btn_Soru3.Visible = false;
            Btn_Soru4.Visible = false;
            Btn_Soru5.Visible = false;
            Btn_Soru6.Visible = false;
            Btn_Soru7.Visible = false;
        }

        private void SoruHarfleriAc()
        {
            if (harfSayisi == 0)
                return;

            Btn_Soru1.Visible = true;
            Btn_Soru1.BackColor = Color.Black;
            Btn_Soru2.Visible = true;
            Btn_Soru2.BackColor = Color.Black;
            Btn_Soru3.Visible = true;
            Btn_Soru3.BackColor = Color.Black;
            Btn_Soru4.Visible = true;
            Btn_Soru4.BackColor = Color.Black;

            if (harfSayisi >= 5)
            {
                Btn_Soru5.Visible = true;
                Btn_Soru5.BackColor = Color.Black;
            }
            if (harfSayisi >= 6)
            {
                Btn_Soru6.Visible = true;
                Btn_Soru6.BackColor = Color.Black;
            }
            if (harfSayisi >= 7)
            {
                Btn_Soru7.Visible = true;
                Btn_Soru7.BackColor = Color.Black;
            }
        }

        private void CevapBtnKapat()
        {
            Btn_Cevap.Visible = false;
            Txt_Cevap.Visible = false;
        }

        private void CevapBtnAc()
        {
            Btn_Cevap.Visible = true;
            Txt_Cevap.Visible = true;
        }

        private void YeniKelimeAl(object sender, EventArgs e)
        {
            sayaç = 0;
            sayaç2 = sayaç2 + 1;

            string[] sorular = { "TANDIR KEBABI MEŞHUR OLAN BİR TURİZM ŞEHRİMİZ", "BİR ATIK ÇEŞİDİ", "SİGARANIN ATIĞI VE AYNI ZAMANDA BİR BALIK TÜRÜ" };
            string turet = "";
            turet += sorular[rnd.Next(sorular.Length)];
            textBox3.Text = turet;

            HarfleriAc();
            CevapBtnAc();

            Btn_Puan.Visible = true;
            Txt_Cevap.Enabled = true;

            if (textBox3.Text == "TANDIR KEBABI MEŞHUR OLAN BİR TURİZM ŞEHRİMİZ")
            {
                Btn_Soru1.Text = "A";
                Btn_Soru2.Text = "N";
                Btn_Soru3.Text = "T";
                Btn_Soru4.Text = "A";
                Btn_Soru5.Text = "L";
                Btn_Soru6.Text = "Y";
                Btn_Soru7.Text = "A";

                harfSayisi = 7;
            }
            else if (textBox3.Text == "BİR ATIK ÇEŞİDİ")
            {
                Btn_Soru1.Text = "P";
                Btn_Soru2.Text = "L";
                Btn_Soru3.Text = "A";
                Btn_Soru4.Text = "S";
                Btn_Soru5.Text = "T";
                Btn_Soru6.Text = "İ";
                Btn_Soru7.Text = "K";

                harfSayisi = 7;
            }
            else if (textBox3.Text == "SİGARANIN ATIĞI VE AYNI ZAMANDA BİR BALIK TÜRÜ")
            {
                Btn_Soru1.Text = "İ";
                Btn_Soru2.Text = "Z";
                Btn_Soru3.Text = "M";
                Btn_Soru4.Text = "A";
                Btn_Soru5.Text = "R";
                Btn_Soru6.Text = "İ";
                Btn_Soru7.Text = "T";

                harfSayisi = 7;
            }

            SoruHarfleriAc();
        }

        private void HarfButonAl(object sender, EventArgs e)
        {
            Button XButon = (Button)sender;

            string XText = XButon.Text;

            CevapAltZeminAc(XText);
        }

        private void CevapAltZeminAc(string XText)
        {
            if (XText == Btn_Soru1.Text)
                Btn_Soru1.BackColor = Color.White;
            if (XText == Btn_Soru2.Text)
                Btn_Soru2.BackColor = Color.White;
            if (XText == Btn_Soru3.Text)
                Btn_Soru3.BackColor = Color.White;
            if (XText == Btn_Soru4.Text)
                Btn_Soru4.BackColor = Color.White;
            if (XText == Btn_Soru5.Text)
                Btn_Soru5.BackColor = Color.White;
            if (XText == Btn_Soru6.Text)
                Btn_Soru6.BackColor = Color.White;
            if (XText == Btn_Soru7.Text)
                Btn_Soru7.BackColor = Color.White;
        }

        private void CevapAl(object sender, EventArgs e)
        {
            if (textBox3.Text == "TANDIR KEBABI MEŞHUR OLAN BİR TURİZM ŞEHRİMİZ")
            {
                if (Txt_Cevap.Text == "ANTALYA")
                {
                    for (int i = 0; i < Txt_Cevap.Text.Length; i++)
                        CevapAltZeminAc(Txt_Cevap.Text.Substring(i, 1));

                    MessageBox.Show("kazandınız");
                    puan = puan + 5000;
                    label1.Text = puan.ToString();
                }
                else
                {
                    MessageBox.Show("tekrar dene");
                    textBox3.Enabled = false;
                }
            }
            if (textBox3.Text == "BİR ATIK ÇEŞİDİ")
            {
                if (Txt_Cevap.Text == "PLASTİK")
                {
                    for (int i = 0; i < Txt_Cevap.Text.Length; i++)
                        CevapAltZeminAc(Txt_Cevap.Text.Substring(i, 1));

                    MessageBox.Show("kazandınız");
                    puan = puan + 5000;
                    label1.Text = puan.ToString();
                }
                else
                {
                    MessageBox.Show("tekrar dene");
                    textBox3.Enabled = false;
                }
            }
            if (textBox3.Text == "SİGARANIN ATIĞI VE AYNI ZAMANDA BİR BALIK TÜRÜ")
            {
                if (Txt_Cevap.Text == "İZMARİT")
                {
                    for (int i = 0; i < Txt_Cevap.Text.Length; i++)
                        CevapAltZeminAc(Txt_Cevap.Text.Substring(i, 1));

                    MessageBox.Show("kazandınız");
                    puan = puan + 5000;
                    label1.Text = puan.ToString();
                }
                else
                {
                    MessageBox.Show("tekrar dene");
                    textBox3.Enabled = false;
                }
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HarfleriKapat();
            SoruHarfleriKapat();
            CevapBtnKapat();

            Btn_Puan.Visible = false;
        }

        
    }
}
