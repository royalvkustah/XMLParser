using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AngleSharp;
using AngleSharp.Xml;
using AngleSharp.Xml.Parser;

namespace XMLParser
{
    class Parser
    {
        public List<Offer> Parsing(string doc)
        {
            var parser = new XmlParser();
            var document=parser.ParseDocument(doc);

            var ids = document.All
                               .Where(m=>m.LocalName=="offer");
            List<Offer> list1 = new List<Offer>();
            foreach (var item in ids)
            {
                list1.Add(new Offer(int.Parse(item.GetAttribute("id")), item.GetAttribute("type"), 
                                    int.Parse(item.GetAttribute("bid")), bool.Parse(item.GetAttribute("available"))));
            }
            return list1;

        }
    }
}
