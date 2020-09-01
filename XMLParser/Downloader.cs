using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace XMLParser
{
    class Downloader
    {
        Uri url = new Uri("http://partner.market.yandex.ru/pages/help/YML.xml");
        public string name = "file.xml";
        public void Download()
        {
            Console.WriteLine("Скачиваем файл");
            WebClient wb = new WebClient();
            wb.DownloadFileAsync(url, name);
            Console.WriteLine("Загрузка закончена, нажмите Enter");
            Console.ReadLine();
        }
    }
}
