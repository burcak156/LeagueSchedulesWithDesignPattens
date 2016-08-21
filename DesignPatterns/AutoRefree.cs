using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class AutoRefree : fixture
    {
        private ArrayList observers;
        maclar fix;
        public AutoRefree()
        {
            observers = new ArrayList();
            fix = new maclar();
        }
        public void notifyObservers()
        {
            foreach (HakemObserver ho in observers)
            {
                ho.refUpdate(fix);
            }
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }
        public void hakemAta(int teamN, int[] Bhakem, int[] Yhakem)
        {
            int teams = teamN;
            // Generate the fixtures using the cyclic algorithm.
            int totalRounds = teams - 1;
            int matchesPerRound = teams / 2;
            int BhakemSayisi = Bhakem.Length;
            int YhakemSayisi = Yhakem.Length;
            int sayac1 = 1;

            while (sayac1 <= totalRounds)
            {
                Random r = new Random();
                int rastgele;
                int Yrastgele;
                int sayac = 0; //sayac sıfırlandı
                int[] sayilar = new int[matchesPerRound];
                int[,] sayilar1 = new int[matchesPerRound,2];
                while (sayac < matchesPerRound)
                {
                    rastgele = r.Next(0, BhakemSayisi);
                    Yrastgele = r.Next(0, YhakemSayisi);
                    if (Array.IndexOf(sayilar, rastgele) == -1 && diziAramaSonuc(sayilar1,Yrastgele)) //dizinin içinde aynı sayı yoksa
                    {
                        sayilar[sayac] = rastgele; //üretilen rastgele sayiyi dizinin sayac kaç ise o elemanına ata
                        sayilar1[sayac, 0] = Yrastgele;
                        
                        fix.basHakemID = Bhakem[rastgele];
                        fix.yHakemID = Yhakem[Yrastgele];
                        fix.hafta = sayac1;
                        int x = 0;
                        while (x < 1)
                        {
                            Yrastgele = r.Next(0, YhakemSayisi);
                            if (diziAramaSonuc(sayilar1, Yrastgele))
                            {
                                sayilar1[sayac, 1] = Yrastgele;
                                fix.iyHakemID = Yhakem[Yrastgele];
                                x++;
                            }
                        }
                        sayac++; //sayacı bir artır
                        refreeChanged();
                    }
                }
                sayac1++;
            }
        }
        public bool diziAramaSonuc(int[,]a, int aranan)
        {
            for (int kolon = 0; kolon < a.Length/2; kolon++)
                for (int satir = 0; satir < 2; satir++)
                    if (a[kolon, satir] == aranan)
                        return false;
            return true;
        }

        public void refreeChanged()
        {
            notifyObservers();
        }
    }
}
