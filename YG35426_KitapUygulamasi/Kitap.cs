using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YG35426_KitapUygulamasi
{
    class Kitap
    {
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string ISBNNo { get; set; }
        public string Tur { get; set; }
        public string YayinEvi { get; set; }
        public DateTime YayinTarihi { get; set; }
        public int SayfaSayisi { get; set; }
        //override boşluk ToString()'i seçin
        public override string ToString()
        {
            return KitapAdi + " >> " + Yazar; 
        }
    }
}
