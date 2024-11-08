using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Concrete
{
    public class KitapRepository : Repository<Kitap>
    {
        public KitapRepository(KitapSatisDBContext context) : base(context)
        {
        }

    }
}
