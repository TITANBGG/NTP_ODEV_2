using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Takip_Sistemi
{
    public class Uye
    {
        public int UyeID { get; set; }
        public string AdSoyad { get; set; }
        public List<Odunc> OduncGecmisi { get; set; } = new List<Odunc>();
    }

}
