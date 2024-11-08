using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Entities;
public class Urun : BaseObject
{
    public string UrunAdi { get; set; }
    public decimal Fiyat { get; set; }
    [NotMapped]
    public IFormFile Resim { get; set; }
    public string ResimDosyasi { get; set; }
    public int KategoriID { get; set; }
    public int EkleyenID { get; set; }
    

}
