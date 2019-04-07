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
        public Form1()
        {
            InitializeComponent();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            float fifoToplam = 0, oncelikliToplam = 0, fifoOrtalama = 0, oncelikliOrtalama = 0, yuzde = 0;
            List<Araba> Arabalar = new List<Araba>();
            Random rastgele = new Random();
            int sira = 1, sayac = 0, sayac2 = 0, zamanf = 0, zamano = 0;
            FIFO fifo = new FIFO(Convert.ToInt32(txtArabaSayisi.Text));
            Oncelikli oncelikli = new Oncelikli(Convert.ToInt32(txtArabaSayisi.Text));
            for(int i=0; i<Convert.ToInt32(txtArabaSayisi.Text);i++)
            {
                Araba a = new Araba();
                a.Numara = sira;
                a.AracCikisSuresi = rastgele.Next(10, 300);
                zamanf += a.AracCikisSuresi;
                a.FIFOIslemTamamlanmaSuresi = zamanf;
                fifoToplam += a.FIFOIslemTamamlanmaSuresi;
                a.kazanc = 0;
                a.OncelikliIslemTamamlanmaSuresi = 0;
                Arabalar.Add(a);
                fifo.Insert(a);
                oncelikli.Insert(a);
                sira++;
            }
           
            for(int i=0; i < Convert.ToInt32(txtArabaSayisi.Text); i++)
            {
                    foreach (Araba arab in Arabalar)
                    {
                        if (oncelikli.Queue[i].Numara == arab.Numara)
                        {
                        zamano += oncelikli.Queue[i].AracCikisSuresi;
                        arab.OncelikliIslemTamamlanmaSuresi = zamano;
                        oncelikliToplam += arab.OncelikliIslemTamamlanmaSuresi;
                        arab.kazanc= arab.FIFOIslemTamamlanmaSuresi - arab.OncelikliIslemTamamlanmaSuresi;
                        }
                    }
            }
            fifoOrtalama = fifoToplam / Convert.ToInt32(txtArabaSayisi.Text);
            oncelikliOrtalama = oncelikliToplam / Convert.ToInt32(txtArabaSayisi.Text);
            lblFifoToplam.Text = fifoToplam.ToString();
            lblOncelikliToplam.Text = oncelikliToplam.ToString();
            lblFifoIslemSureleriOrt.Text = fifoOrtalama.ToString();
            lblOncelikliIslemSureleriOrt.Text = oncelikliOrtalama.ToString();
            lblOrtFark.Text = (fifoOrtalama - oncelikliOrtalama).ToString();
            yuzde = 100 - (100 * oncelikliOrtalama / fifoOrtalama);
            lblYuzde.Text = yuzde.ToString();
            foreach (Araba arab in Arabalar)
            {
                listView1.Items.Add((sayac+1).ToString());
                listView1.Items[sayac].SubItems.Add(arab.Numara.ToString());
                listView1.Items[sayac].SubItems.Add(arab.AracCikisSuresi.ToString());
                listView1.Items[sayac].SubItems.Add(arab.FIFOIslemTamamlanmaSuresi.ToString());
                if(arab.kazanc>0)
                {
                    listView3.Items.Add((arab.Numara).ToString());
                    listView3.Items[sayac2].SubItems.Add(arab.kazanc.ToString());
                    sayac2++;
                }
                sayac++;
            }
            for (int i = 0; i < Convert.ToInt32(txtArabaSayisi.Text); i++)
            {
                listView2.Items.Add((i + 1).ToString());
                listView2.Items[i].SubItems.Add(oncelikli.Queue[i].Numara.ToString());
                listView2.Items[i].SubItems.Add(oncelikli.Queue[i].AracCikisSuresi.ToString());
                listView2.Items[i].SubItems.Add(oncelikli.Queue[i].OncelikliIslemTamamlanmaSuresi.ToString());
                fifo.Remove();
                oncelikli.Remove();
            }
            btnListele.Enabled = false;
        }
    }
}
