using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk_Implemantasyonu
{
   public class PriorityQueue : IQueue
    {
        //MAX ISLEM SURELİ ONCELİKLİ
       public Musteri[] oncelik;
        public int count;
        public int front = -1;
        public int size = 0;
        public int ortalama2;
        public PriorityQueue(int Size)
        {
            count =Size;
            oncelik = new Musteri[Size];
        }
        List<string> liste = new List<string>();
        public string elemanlar(DateTime time,int a)
        {
            DateTime islemTamamlama = new DateTime();
            TimeSpan fark = (time-oncelik[a].girisZamani);
            TimeSpan islemSuresi = new TimeSpan(0, 0, 0, oncelik[a].islemSuresi);
            DateTime date = islemTamamlama.Add(islemSuresi);
            DateTime sonuc = date.Add(fark);

            oncelik[a].girisZamani = sonuc;

            ortalama2 += ((sonuc.Hour * 3600) + (sonuc.Minute * 60) + (sonuc.Second)) / 20;
            string temp;
                temp = "Musteri Numarasi:" + oncelik[a].musteriNumarasi + " Islem tam Suresi:" + sonuc.Hour + ":" + sonuc.Minute + ":" + sonuc.Second;
            return temp;
        }
        public void insert(Musteri item)
        {
            if (count == size)
                throw new Exception("Queue dolu");
            if (isEmpty())
            {
                front++;
                oncelik[front] = item;
               
            }
            else
            {
                int i;
                for (i = size - 1; i >= 0; i--)
                {
                    if ((int)item.islemSuresi > (int)oncelik[i].islemSuresi)
                        oncelik[i + 1] = oncelik[i];
                    else
                        break;
                }
                oncelik[i + 1] = item;
                front++;
            }
            size++;
        }

        public bool isEmpty()
        {
            if (size == 0)
                return true;
            return false;
        }

        public Musteri peek()
        {
            if (size != 0)
                return oncelik[front];
            else return null;
        }

        public Musteri remove()
        {
            if (this.isEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            Musteri temp = oncelik[front];
            oncelik[front] = null;
            front--; size--;
            return temp;
        }
    }
}
