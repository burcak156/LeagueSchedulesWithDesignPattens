using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class MusabakaController : Observer,FixtureDisplay,HakemObserver
    {
        private CreateFixture createFixture;
        private AutoRefree autoRefree;
        public MusabakaController(CreateFixture createFixture)
        {
            this.createFixture = createFixture;
            createFixture.registerObserver(this);
        }

        public MusabakaController(AutoRefree autoRefree)
        {
            this.autoRefree = autoRefree;
            autoRefree.registerObserver(this);
        }

        public maclar[] fixtureListele()
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                var mc = from f in sdb.maclars
                         select f;

                return mc.ToArray();
            }
        }

        public void fixUpdate(maclar mac)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                sdb.maclars.Add(mac);
                sdb.SaveChanges();
            }
        }

        public void refUpdate(maclar mac)
        {
            using (spordbEntities sdb = new spordbEntities())
            {
                maclar macs = (from p in sdb.maclars
                              where p.basHakemID == null && p.hafta == mac.hafta
                              select p).Take(1).FirstOrDefault();
                macs.basHakemID = mac.basHakemID;
                macs.yHakemID = mac.yHakemID;
                macs.iyHakemID = mac.iyHakemID;
                sdb.SaveChanges();
            }
        }
    }
}