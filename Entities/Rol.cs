using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rol
    {
        public int RolID { get; set; }
        public string RolAdi { get; set; }

        public ICollection<Kullanici> Kullanicilar { get; set; }
    }
}
