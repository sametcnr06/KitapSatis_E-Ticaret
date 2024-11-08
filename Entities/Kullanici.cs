using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entities;
public class Kullanici 
{
    [Key]
    public int KullaniciID { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string KullaniciAdi { get; set; }
    public string Sifre { get; set; }

    public int RolID { get; set; }
    public Rol Rol { get; set; }
}
