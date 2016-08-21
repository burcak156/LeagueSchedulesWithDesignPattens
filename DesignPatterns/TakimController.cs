using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class TakimController
    {
        public TakimController()
        {

        }
        public bool takimVeriEkle(takimlar tkmlar)
        {
            try
            {
                using (spordbEntities sdb = new spordbEntities())
                {

                    sdb.takimlar.Add(tkmlar);
                    sdb.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void takimSil(takimlar tkmlar)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                takimlar t = sdb.takimlar.FirstOrDefault(x => x.id == tkmlar.id);
                sdb.takimlar.Attach(t);
                sdb.takimlar.Remove(t);
                sdb.SaveChanges();
            }
        }

        public void takimDuzenle(takimlar tkmlar)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                takimlar t = sdb.takimlar.FirstOrDefault(x => x.id == tkmlar.id);
                t.adi = tkmlar.adi; t.lig = tkmlar.lig; t.diger = tkmlar.diger; t.sehir = tkmlar.sehir; t.salonID = tkmlar.salonID;
                sdb.SaveChanges();
            }
        }

        public takimlar[] takimAra(string search)
        {
            using (spordbEntities sdb = new spordbEntities())
            {

                var tk = from s in sdb.takimlar
                         select s;
                if (!String.IsNullOrEmpty(search))
                {
                    tk = tk.Where(s => s.adi.Contains(search)
                                || s.lig.Contains(search)
                                || s.diger.Contains(search)
                                || s.sehir.Contains(search));
                }
                return tk.ToArray();
            }
        }

        public takimlar[] takimListele()
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var tk = from s in sdb.takimlar.Include("salonlar")
                         select s;

                return tk.ToArray();
            }
        }

        public int takimSayisi(string lig)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                int count = (from p in sdb.takimlar
                             where p.lig == lig
                             select p).Count();
                return count;
            }
        }

        public List<int> takimID(string lig)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var takimID = from p in sdb.takimlar
                               where p.lig == lig 
                               select p.id;

                return takimID.ToList();
            }
        }
        public List<int> salonID(int id)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var sID = from p in sdb.takimlar
                              where p.id == id
                              select p.salonlar.id;
                return sID.ToList();
            }
        }
    }
}





