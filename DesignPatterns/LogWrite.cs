using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class LogWrite : Observer, HakemObserver
    {
        private CreateFixture createFixture;
        private AutoRefree autoRefree;
        public LogWrite(CreateFixture createFixture)
        {
            this.createFixture = createFixture;
            createFixture.registerObserver(this);
        }

        public LogWrite(AutoRefree autoRefree)
        {
            this.autoRefree = autoRefree;
            autoRefree.registerObserver(this);
        }

        public void fixUpdate(maclar mac)
        {
            string path = @"C:\Users\BURCAK\Documents\Visual Studio 2015\Projects\DesignPatterns\DesignPatterns\atamalar.log";
            
            StreamWriter sw;
            using (sw = File.AppendText(path))
            {
                sw.WriteLine(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString()+ " : " + mac.ligAdi + " fikstürü oluşturuldu.");
                sw.Close();
            }
        }

        public void refUpdate(maclar mac)
        {
            string path = @"C:\Users\BURCAK\Documents\Visual Studio 2015\Projects\DesignPatterns\DesignPatterns\atamalar.log";

            StreamWriter sw;
            using (sw = File.AppendText(path))
            {
                sw.WriteLine(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + " : " + mac.ligAdi + " hakem atamaları gerçekleştirildi.");
                sw.Close();
            }
        }
    }
}
