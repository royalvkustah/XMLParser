using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using AngleSharp;
using System.IO;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Downloader dw = new Downloader();
            dw.Download();

            Parser parser = new Parser();
            List<Offer> list = new List<Offer>();
            list=parser.Parsing(File.ReadAllText("file.xml"));
            using (StreamWriter sw=new StreamWriter("ids.txt"))
            {
                foreach (var item in list)
                {
                    sw.WriteLine("ID = "+item.id);
                }
            }
            Console.WriteLine("Данные записаны в файл, нажмите Enter чтобы выйти");
            Console.ReadLine();
        }
    }
}
