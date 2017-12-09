using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuyruk_Implemantasyonu
{
    public partial class Form1 : Form
    {
        Kuyruk k = new Kuyruk(20);
        MinPriorityQueue min = new MinPriorityQueue(20);
        PriorityQueue max = new PriorityQueue(20);
        public Form1()
        {
            InitializeComponent();
        }
        public int SaniyeHesapla(DateTime time)
        {
            return (time.Hour * 3600 )+ (time.Minute * 60) + time.Second;
        }
        
        private void btnCircular_Click(object sender, EventArgs e)
        {

            Random rastgele = new Random();
            Random rst = new Random();
            for (int i = 0; i < 20; i++)
            {
                Musteri m = new Musteri();
                m.islemSuresi = rastgele.Next(60, 600);
                m.musteriNumarasi = rst.Next();
                m.girisZamani = DateTime.Now;
                k.insert(m);
                min.insert(m);
                max.insert(m);
            }
            lstMax.Items.Add("Max Priority Islem Tamamlanma Sureleri");
            lstMin.Items.Add("Min Priority Islem Tamamlanma Sureleri");
            lstCircular.Items.Add("Circular Queue Islem Tamamlanma Sureleri");
            lstMaxEk.Items.Add("Max Priority < Circular queue");
            lstMinEk.Items.Add("Min Pri. < Circular queue ");
            Musteri[] minListe = new Musteri[20];
            Musteri[] maxListe=new Musteri[20];
            Musteri[] cListe=new Musteri[20];
            
            for (int i = 19; i >=0; i--)
            {
                if (k.front != -1 && max.front != -1 && min.front != -1)
                {
                    lstMax.Items.Add(max.elemanlar(DateTime.Now, max.front));
                    lstMin.Items.Add(min.elemanlar(DateTime.Now, min.front));
                    lstCircular.Items.Add(k.elemanlar(DateTime.Now, k.front));
                }
                minListe[i]=min.remove();
                cListe[i] = k.remove();
                maxListe[i] = max.remove();
            }

            for (int i = 0; i < 20; i++)
            {
                Musteri m =cListe[i];
                for (int j = 0; j < 20; j++)
                {
                    if((m.musteriNumarasi==minListe[j].musteriNumarasi)&& (SaniyeHesapla(m.girisZamani)>SaniyeHesapla(minListe[j].girisZamani)))
                        { lstMinEk.Items.Add("musteri nu:" + m.musteriNumarasi + "islem suresi:" + m.islemSuresi + "fark:" +(SaniyeHesapla(m.girisZamani)-SaniyeHesapla(min.MinOncelik[j].girisZamani)).ToString()); }
                    if((m.musteriNumarasi==maxListe[j].musteriNumarasi)&&(SaniyeHesapla(m.girisZamani)>SaniyeHesapla(maxListe[j].girisZamani)))
                        { lstMaxEk.Items.Add("musteri nu:" + m.musteriNumarasi + "islem suresi:" + m.islemSuresi + "fark:" + (SaniyeHesapla(m.girisZamani) - SaniyeHesapla(max.oncelik[j].girisZamani)).ToString()); }
                    if ((m.musteriNumarasi == minListe[j].musteriNumarasi) && (SaniyeHesapla(m.girisZamani) == SaniyeHesapla(minListe[j].girisZamani)))
                        { lstMinEk.Items.Add("musteri nu:" + m.musteriNumarasi + "islem suresi:" + m.islemSuresi + "fark:0"); }
                    if ((m.musteriNumarasi == maxListe[j].musteriNumarasi) && (SaniyeHesapla(m.girisZamani) == SaniyeHesapla(maxListe[j].girisZamani)))
                        { lstMaxEk.Items.Add("musteri nu:" + m.musteriNumarasi + "islem suresi:" + m.islemSuresi + "fark:0"); }

                }

            }

            lstCircular.Items.Add("ortalama " + k.ortalama+" saniye");
            lstMax.Items.Add("ortalama " + max.ortalama2 + " saniye");
            lstMin.Items.Add("ortalama" + min.ortalama1 + " saniye");   
            
             
                 
        }
    }
}
