using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakülte
{
    internal class Bolum:Faculty
    {
        public string bölümAd { get; set; }
        public string  KurulusYıl { get; set; }
       
        public Bolum():base()
        {
            uniAd = "Ege";
            Console.WriteLine(uniAd+"\n"+sehir);
        }
        
        public void info()
        {
            Console.WriteLine(bölümAd + "\n" + fakülteAd + "\n" + KurulusYıl + "\n"+KampüsAd);
        }
    }
}
