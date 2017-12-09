import random
import time
from abc import ABC, abstractmethod
import datetime


class MusteriNode:
    def __init__(self, giriszamani):
        self.islemSuresi = random.randrange(60, 600)
        self.musteriNo = random.randrange(1, 20)
        self.giriszamani = giriszamani
        self.TamamlanmaSure = datetime.timedelta(seconds=0)
        self.Next = None


class Kuyruk(ABC):
    @abstractmethod
    def kuyrugaEkle(self, musteri1):
        pass

    @abstractmethod
    def kuyruguTemizle(self, now1):
        pass


class FIFO(Kuyruk):
    cikanMusterilerFIFO = []
    Head = None

    def __init__(self):
        pass

    def kuyrugaEkle(self, musteri1):
        super().kuyrugaEkle(musteri1)
        if self.Head is None:
            self.Head = musteri1
        else:
            tmpnode = self.Head
            while tmpnode.Next is not None:
                tmpnode = tmpnode.Next
                if tmpnode.Next is None:
                    print("yaz")
            tmpnode.Next = musteri1

    def kuyruguTemizle(self, now1):
        super().kuyruguTemizle(now1)
        head = self.Head
        head.TamamlanmaSure = now1 - head.giriszamani
        head.TamamlanmaSure = head.TamamlanmaSure + datetime.timedelta(seconds=head.islemSuresi)
        self.cikanMusterilerFIFO.append(head)
        self.Head = head.Next


'''class PQ(Kuyruk):
    cikanmusterilerPQ = []
    Head1 = None
    def kuyruguTemizle(self, now1):
        super().kuyruguTemizle(now1)
        head1 = self.Head1
        head1.TamamlanmaSure = now1 - head1.giriszamani + datetime.timedelta(seconds=head1.islemSuresi)

        self.cikanmusterilerPQ.append(head1)
        self.Head1 = head1.Next

    def kuyrugaEkle(self, musteri1):
        super().kuyrugaEkle(musteri1)
        if self.Head1 is None:
            self.Head1 = musteri1
        else:
            yerlestimi = False
            tmpnode1 = self.Head1
            parent = None
            while tmpnode1.Next is not None:
                if musteri1.islemSuresi < tmpnode1.islemSuresi:
                    musteri1.Next = tmpnode1
                    if tmpnode1 is self.Head1:
                        self.Head1 = musteri1
                    else:
                        parent.next = musteri1
                    yerlestimi = True
                    break
                else:
                    parent = tmpnode1
                    tmpnode1 = tmpnode1.Next
            if yerlestimi is False:
                tmpnode1.Next = musteri1
'''
fifo = FIFO()
#pq = PQ()
for i in range(0, 20):
    musteri = MusteriNode(datetime.datetime.now())
    ##fifo.kuyrugaEkle(musteri)
    #pq.kuyrugaEkle(musteri)
time.sleep(3)
for k in range(0, 20):
    now = datetime.datetime.now()
    fifo.kuyruguTemizle(now)
    #pq.kuyruguTemizle(now)
print("----FIFO----")
ortalama = datetime.timedelta(seconds=0)
for a in fifo.cikanMusterilerFIFO:
    print(a.musteriNo, "   ", a.TamamlanmaSure, "\n")
    ortalama = ortalama + a.TamamlanmaSure
print("Ortalama:  " + str(ortalama / 20))
'''print("----PQ----")
ortalama = datetime.timedelta(seconds=0)
for a in #pq.cikanmusterilerPQ:
    print(a.musteriNo, "   ", a.TamamlanmaSure, "\n")
    ortalama = ortalama + a.TamamlanmaSure
print("Ortalama:  " + str(ortalama / 20))'''
