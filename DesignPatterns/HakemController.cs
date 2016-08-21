using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class HakemController
    {

        public HakemController()
        {

        }
        
        public bool hakemVeriEkle(hakem h)
        {
            try
            {
                using (spordbEntities sdb = new spordbEntities())
                {
                    sdb.hakem.Add(h);
                    sdb.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public hakem[] hakemListele()
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var hk = from h in sdb.hakem
                         select h;
                return hk.ToArray();
            }
        }

        public void hakemSil(hakem hkmler)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                hakem hk = sdb.hakem.FirstOrDefault(x => x.id == hkmler.id);
                sdb.hakem.Attach(hk);
                sdb.hakem.Remove(hk);
                sdb.SaveChanges();
            }
        }

        public void hakemDuzenle(hakem hkmler)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                hakem hk = sdb.hakem.FirstOrDefault(x => x.id == hkmler.id);
                hk.adi = hkmler.adi; hk.soyadi = hkmler.soyadi; hk.sehir = hkmler.sehir; hk.klasmani = hkmler.klasmani; hk.gorev = hkmler.gorev; hk.diger = hkmler.diger;
                sdb.SaveChanges();
            }
        }
        public hakem[] hakemAra(string search)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var hk = from h in sdb.hakem
                         select h;
                if (!String.IsNullOrEmpty(search))
                {
                    hk = hk.Where(h => h.adi.Contains(search)
                                || h.soyadi.Contains(search)
                                || h.klasmani.Contains(search)
                                || h.sehir.Contains(search)
                                || h.gorev.Contains(search)
                                || h.diger.Contains(search));
                }
                return hk.ToArray();
            }
        }
        public List<int> bHakemID(string lig)
        {
            string klasmanAdi;
            if (lig == "Türkiye Basketbol Ligi" || lig == "Türkiye Kadınlar Basketbol Ligi")
                klasmanAdi = "A Klasmanı";
            else if (lig == "Türkiye Erkekler Basketbol 2.Ligi" || lig == "Türkiye Kadınlar Basketbol 2.Ligi")
                klasmanAdi = "B Klasmanı";
            else
                klasmanAdi = "C Klasmanı";
            
            using (spordbEntities sdb = new spordbEntities())
            {
                var bHakemID = from h in sdb.hakem
                              where h.klasmani == klasmanAdi && h.gorev == "Baş Hakem"
                              select h.id;

                return bHakemID.ToList();
            }
        }
        public List<int> yHakemID(string lig)
        {
            string klasmanAdi;
            if (lig == "Türkiye Basketbol Ligi" || lig == "Türkiye Kadınlar Basketbol Ligi")
                klasmanAdi = "A Klasmanı";
            else if (lig == "Türkiye Erkekler Basketbol 2.Ligi" || lig == "Türkiye Kadınlar Basketbol 2.Ligi")
                klasmanAdi = "B Klasmanı";
            else
                klasmanAdi = "C Klasmanı";

            using (spordbEntities sdb = new spordbEntities())
            {
                var yHakemID = from h in sdb.hakem
                               where h.klasmani == klasmanAdi && h.gorev == "Yan Hakem"
                               select h.id;

                return yHakemID.ToList();
            }
        }

    }
}
