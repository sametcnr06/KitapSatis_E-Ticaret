using Business.Abstract;
using Core.Abstract;
using Core.Concrete;
using DATA.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly IKullaniciRepository _kullaniciRepository;

        public KullaniciManager(IKullaniciRepository kullaniciRepository)
        {
            _kullaniciRepository = kullaniciRepository;
        }

        public IExceptionResult Add(Kullanici kullanici)
        {
            _kullaniciRepository.Add(kullanici);

            return new SuccessResult("Kullanici Kaydı Başarılı");
        }
    }
}
