using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuyruk_Implemantasyonu
{
    interface IQueue
    {
        
        void insert(Musteri item);
        Musteri remove();
        Musteri peek();
        bool isEmpty();
        string elemanlar(DateTime time,int a);
    }
}
