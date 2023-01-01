using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakülte
{
  public class Faculty: Universite
    {
        public string fakülteAd { get; set; }
        public string KampüsAd { get; set; }

      
        public Faculty()
        {
            uniAd = "SDÜ";
            sehir = "Sparta";
        }
    }
}
