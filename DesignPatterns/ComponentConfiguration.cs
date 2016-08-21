using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace DesignPatterns
{
    public class ComponentConfiguration
    {
        XDocument doc;

        private static ComponentConfiguration cc = new ComponentConfiguration();
        private ComponentConfiguration()
        {
            doc = XDocument.Load(@"C:\Users\BURCAK\Documents\Visual Studio 2015\Projects\DesignPatterns\DesignPatterns\componentsconfig.xml");
        }

        public string getTextboxStyle(string type, string ozellik) {

            string result = null;
            var txtOz = from textbox in doc.Descendants("textbox")
                        where textbox.Attribute("type").Value == type
                        select textbox;
            foreach (var tx in txtOz)
            {
                  result = tx.Element(ozellik).Value;
            }
            return result;
        }

        public string getButtonStyle(string type, string ozellik)
        {
            string result = null;
            var buttonOz = from button in doc.Descendants("button")
                        where button.Attribute("type").Value == type
                        select button;
            foreach (var bt in buttonOz)
            {
                result = bt.Element(ozellik).Value;
            }
            return result;
        }
        public string getdataGridStyle(string type, string ozellik)
        {
            string result = null;
            var dataOz = from dtgrid in doc.Descendants("button")
                           where dtgrid.Attribute("type").Value == type
                           select dtgrid;
            foreach (var dt in dataOz)
            {
                result = dt.Element(ozellik).Value;
            }
            return result;
        }

        public string getLabelStyle(string type, string ozellik)
        {
            string result = null;
            var labelOz = from label in doc.Descendants("label")
                           where label.Attribute("type").Value == type
                           select label;
            foreach (var bt in labelOz)
            {
                result = bt.Element(ozellik).Value;
            }
            return result;
        }
        public string gettabPageStyle(string type, string ozellik)
        {
            string result = null;
            var tabOz = from tabPage in doc.Descendants("tabpage")
                          where tabPage.Attribute("type").Value == type
                          select tabPage;
            foreach (var tp in tabOz)
            {
                result = tp.Element(ozellik).Value;
            }
            return result;
        }

        public string getcomboBoxStyle(string type, string ozellik)
        {
            string result = null;
            var cmbOz = from comboBox in doc.Descendants("combobox")
                        where comboBox.Attribute("type").Value == type
                        select comboBox;
            foreach (var cb in cmbOz)
            {
                result = cb.Element(ozellik).Value;
            }
            return result;
        }

        public static ComponentConfiguration getInstance() {
            return cc;
        }
    }
}