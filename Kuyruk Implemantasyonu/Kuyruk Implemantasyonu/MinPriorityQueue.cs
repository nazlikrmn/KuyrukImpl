using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk_Implemantasyonu
{
    public class MinPriorityQueue:IQueue
    {
       public Musteri[] MinOncelik;
        public int count;
        public int front = -1;
        public int size = 0;
        public int ortalama1;

        public MinPriorityQueue(int Size)
        {
            count = Size;
            MinOncelik = new Musteri[Size];
        }
        public string elemanlar(DateTime time,int a)
        {
            string temp = "";
            int i = a;
            DateTime islemTamamlama = new DateTime();
            TimeSpan fark =( time-MinOncelik[i].girisZamani);
            TimeSpan islemSuresi = new TimeSpan(0, 0, 0,MinOncelik[i].islemSuresi);
            DateTime date = islemTamamlama.Add(islemSuresi);
            DateTime sonuc = date.Add(fark);

            MinOncelik[a].girisZamani = sonuc;

            ortalama1 += ((sonuc.Hour * 3600) + (sonuc.Minute * 60) + (sonuc.Second)) / 20;
            temp = "Musteri Numarasi:" +MinOncelik[i].musteriNumarasi + " Islem tam Suresi:" + sonuc.Hour+":"+sonuc.Minute+":"+sonuc.Second;
            return temp;
        }

        public void insert(Musteri item)
        {
            
            if (isEmpty())
            {
                front++;
                MinOncelik[front] = item;
            }
           
           else
            {
                int i;
                for (i = size-1; i >=0; i--)
                {
                    if (item.islemSuresi < MinOncelik[i].islemSuresi)
                        MinOncelik[i + 1] = MinOncelik[i];
                    else
                        break;
                }
                MinOncelik[i + 1] = item;
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
                return MinOncelik[front];
            else return null;
        }

        public Musteri remove()
        {
            if (this.isEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            Musteri temp = MinOncelik[front];
            MinOncelik[front] = null;
            front--; size--;
            return temp;
        }
    }
}

