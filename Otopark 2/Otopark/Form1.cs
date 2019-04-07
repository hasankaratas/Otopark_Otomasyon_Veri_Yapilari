using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{ 
    public partial class Form1 : Form
    {
        public int Jose(int uz)
        {
            int n = uz;
            int a = 1;
            int x = 1;
            while (true)
            {
                if ((n / 2) >= 2)
                {
                    n = n / 2;
                    a++;
                }
                else
                    break;
            }
            for (int i = 0; i < a; i++)
            {
                x = x * 2;
            }
            n = uz;
            int l = n - x;
            if (n == 1)
            {
                l = 0;
            }
            return (2 * l + 1);
        }
        string[] renkler = { "Deniz mavisi ", "Sarı", "Ametist rengi", "Barut rengi",  "Beyaz",  "Camgöbeği", "Yonca yeşili", "Çam yeşili", "Çikolata rengi", "Şeftali rengi", "Bakır rengi", "Gece mavisi", "Gri", "Açık yeşil",  "Haki", "Hardal rengi", "Kahverengi", "Karanfil rengi", "Kayısı rengi", "Kehribar rengi", "Kırmızı",  "Koyu kırmızı", "Bej", "Koyu mavi", "Lacivert", "Lavanta rengi ", "Limoni",   "Mor", "Nar rengi", "Orman yeşili", "Bordo", "Pastel yeşili", "Menekşe rengi", "Açık mavi", "Kiraz kırmızısı", "Prusya mavisi", "Fildişi rengi",  "Siyah",  "Gül rengi", "Turkuaz", "Turuncu", "Yeşil",  "Zümrüt yeşili ", "Mavi", "Altınımsı" };
        Bodrum bodrum = new Bodrum(15);
        Zemin zemin = new Zemin(45);
        Kat_2 kat_2 = new Kat_2();
        public int sayac2 = 0, sayac3 = 0, sayac4 = 15, sayac5 = 0;
        float zaman = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman++;
        }

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sayac5++;
            int sayac = 1;
            string b;
            Random rastgele = new Random();
            int sayi = rastgele.Next(1,3);
            if(sayac2==15)
            {
                sayi = 2;
            }
            if(sayac3==15)
            {
                sayi = 1;
            }
            if((sayac2+sayac3)==30)
            {
                string temp;
                temp = zemin.Remove();
                listView5.Items.Add(temp);
                listView2.Items.Clear();
                for (int i = 0; i < 45; i++)
                {
                    listView2.Items.Add((i + 1).ToString());
                    listView2.Items[i].SubItems.Add(zemin.Queue[i]);
                }
                if (sayac5 == 45)
                {
                    timer1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("Son Çıkan Aracın Rengi : " + temp);
                    MessageBox.Show("5 Saniyede Ortalama Çıkan Araç Sayısı : "+ (45/zaman) * 5);
                }
            }
            if(sayi==1 && sayac2<15)
            {
                listView5.Items.Add(zemin.Remove());
                b = bodrum.Pop();
                zemin.Insert(b);
                listView6.Items.Add(b);
                listView2.Items.Clear();
                listView1.Items.Clear();
                for (int i = 0; i < 45; i++)
                {
                    listView2.Items.Add((i + 1).ToString());
                    listView2.Items[i].SubItems.Add(zemin.Queue[i]);
                }

                for (int i = bodrum.top; 0 <= i; i--)
                {
                    listView1.Items.Add(sayac.ToString());
                    listView1.Items[sayac - 1].SubItems.Add(bodrum.items[i]);
                    sayac++;
                }
                sayac2++;
            }
            if(sayi==2 && sayac3<15)
            {   int x;
                listView5.Items.Add(zemin.Remove());
                x = Jose(sayac4);
                b = kat_2.GetElement(x-1).Data;
                kat_2.DeletePos(x-1);
                zemin.Insert(b);
                listView4.Items.Add(b);
                listView2.Items.Clear();
                listView3.Items.Clear();
                for (int i = 0; i < 45; i++)
                {
                    listView2.Items.Add((i + 1).ToString());
                    listView2.Items[i].SubItems.Add(zemin.Queue[i]);
                    if(i<15)
                    listView3.Items.Add((i + 1).ToString());
                }
                for (int i = kat_2.Size-1; 0 <= i; i--)
                {
                    listView3.Items[sayac - 1].SubItems.Add(kat_2.GetElement(sayac - 1).Data);
                    sayac++;
                }
                sayac4--;
                sayac3++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayac = 1;
            for(int i=0; i<15; i++)
            {
                bodrum.Push(renkler[i]);
                zemin.Insert(renkler[i + 15]);
                listView2.Items.Add((i+1).ToString());
                listView2.Items[i].SubItems.Add(zemin.Queue[i]);
                listView3.Items.Add((i + 1).ToString());
            }
            for (int i = 44; i > 29; i--)
            {
                kat_2.InsertFirst(renkler[i]);
            }
            
            for(int i = bodrum.items.Length - 1; 0 <= i; i--) 
            {
                listView1.Items.Add(sayac.ToString());
                listView1.Items[sayac - 1].SubItems.Add(bodrum.items[i]);
                listView3.Items[sayac-1].SubItems.Add(kat_2.GetElement(sayac-1).Data);
                sayac++;
            }
        }
    }
}
