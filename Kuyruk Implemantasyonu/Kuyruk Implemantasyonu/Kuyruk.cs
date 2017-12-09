using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk_Implemantasyonu
{
    class Kuyruk: IQueue
    {
       public Musteri[] kuyruk;
        public int count;
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        public int ortalama;
        public Kuyruk(int Size)
        {
            count = Size;
            kuyruk = new Musteri[Size];
        }
        public void insert(Musteri item)
        {
            if (size != count)
            {
                if (front == -1)
                    front++;
                if (rear != count - 1)
                    rear++;
                else if (rear == count - 1 && front != -1)
                    rear = 0;

                else if (rear < front && rear != front - 1)
                    rear++;
                kuyruk[rear] = item;
                size++;
            }

           else if (size == count)
                throw new Exception("Queue doldu.");

        }

        public Musteri remove()
        {
            Musteri m;
            m = kuyruk[front];
            Array.Clear(kuyruk, front, 1);
            if (front != count - 1)
                front++;
            else
                front = -1;
            size--;
            return m;
        }

        public Musteri peek()
        {
            if(front!=-1)
                return kuyruk[front];
            return null;
        }

        public bool isEmpty()
        {
            if (size == 0)
                return true;
            return false;
        }

        public string elemanlar(DateTime time,int a)
        {
            string temp = "";
            int i = a;
            DateTime islemTamamlama = new DateTime();
            TimeSpan fark = (time-kuyruk[i].girisZamani);
            TimeSpan islemSuresi = new TimeSpan(0, 0, 0, kuyruk[i].islemSuresi);
            DateTime date = islemTamamlama.Add(islemSuresi);
            DateTime sonuc = date.Add(fark);

            kuyruk[i].girisZamani = sonuc;

            ortalama += ((sonuc.Hour * 3600) + (sonuc.Minute * 60) + (sonuc.Second)) / 20;
            temp = "Musteri Numarasi:"+ kuyruk[i].musteriNumarasi + " İslem tam Suresi:" + sonuc.Hour + ":" + sonuc.Minute + ":" + sonuc.Second;
            
            return temp;
        }

    }
}
