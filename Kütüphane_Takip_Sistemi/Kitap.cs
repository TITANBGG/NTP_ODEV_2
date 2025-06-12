using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Takip_Sistemi
{
    public class Kitap
    {
        public string ISBN { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public bool OduncDurumu { get; set; } = false;

        // 🆕 Eklenen Özellik: İade tarihi
        public DateTime? IadeTarihi { get; set; }

        public override string ToString()
        {
            return $"{Ad} - {Yazar} ({ISBN})";
        }
    }
}
    

