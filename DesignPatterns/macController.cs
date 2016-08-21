using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class macController
    {
        public maclar[] ligMacAra(string search)
        {
            using (spordbEntities sdb = new spordbEntities())
            {

                var tk = from s in sdb.maclars
                         select s;
                if (!String.IsNullOrEmpty(search))
                {
                    tk = tk.Where(s => s.ligAdi.Contains(search)
                                || s.takimlar.adi.Contains(search)
                                || s.salonlar.adi.Contains(search)
                                || s.takimlar1.adi.Contains(search)
                                );
                }
                return tk.ToArray();
            }
        }

        public void macDuzenle(maclar mc)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                maclar m = sdb.maclars.FirstOrDefault(x => x.macID == mc.macID);
                m.salonID = mc.salonID; m.basHakemID = mc.basHakemID; m.yHakemID = mc.yHakemID; m.iyHakemID = mc.iyHakemID;
                sdb.SaveChanges();
            }
        }

        public List<int> haftaGetir(string v)
        {
        
            using (spordbEntities sdb = new spordbEntities())
            {
                var hafta = (from p in sdb.maclars
                             where p.ligAdi == v
                             select p.hafta).Distinct().ToList();


                return hafta.Where(x => x != null).Select(x => x.Value).ToList();
            }
        }

        public maclar[] ligMacAra(string hafta, string lig)
        {
            int ligHafta = Int32.Parse(hafta);
            using (spordbEntities sdb = new spordbEntities())
            {

                var tk = from s in sdb.maclars
                         where s.ligAdi == lig && s.hafta== ligHafta
                         select s;
              
               return tk.ToArray();
            }
        }
    }
}
