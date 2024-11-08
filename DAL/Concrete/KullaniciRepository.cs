using DATA.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Concrete
{
    public class KullaniciRepository : EntityRepository<Kullanici,KitapSatisDBContext>,IKullaniciRepository
    {
    }
}
