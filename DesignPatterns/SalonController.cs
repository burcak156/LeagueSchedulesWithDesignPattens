using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class SalonController
    {
        public SalonController()
        {

        }

        public bool salonVeriEkle(salonlar s)
        {
            try
            {
                using (spordbEntities sdb = new spordbEntities())
                {
                    sdb.salonlar.Add(s);
                    sdb.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void salonSil(salonlar slnlar)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                salonlar sl = sdb.salonlar.FirstOrDefault(x => x.id == slnlar.id);
                sdb.salonlar.Attach(sl);
                sdb.salonlar.Remove(sl);
                sdb.SaveChanges();
            }
        }

        public void salonDuzenle(salonlar slnlar)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                salonlar s = sdb.salonlar.FirstOrDefault(x => x.id == slnlar.id);
                s.adi = slnlar.adi; s.sehir = slnlar.sehir; s.ligi = slnlar.ligi; s.diger = slnlar.diger;
                sdb.SaveChanges();
            }
        }

        public salonlar[] salonAra(string search)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var sl = from s in sdb.salonlar
                         select s;
                if (!String.IsNullOrEmpty(search))
                {
                    sl = sl.Where(s => s.adi.Contains(search)
                                || s.sehir.Contains(search)
                                || s.ligi.Contains(search)
                                || s.diger.Contains(search));
                }
                return sl.ToArray();
            }
        }

        public salonlar[] salonListele()
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var sl = from s in sdb.salonlar
                         select s;
                return sl.ToArray();
            }
        }
    }
}