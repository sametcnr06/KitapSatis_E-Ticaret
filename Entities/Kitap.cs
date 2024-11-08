using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public float Fiyat { get; set; }
        public int BasimYili { get; set; }
        public int YayinEviID { get; set; }
        public YayinEvi YayinEvi { get; set; }
        public string KapakResmi { get; set; }
    }
}
