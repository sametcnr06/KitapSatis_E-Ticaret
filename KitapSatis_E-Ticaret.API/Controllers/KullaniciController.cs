using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KitapSatis_E_Ticaret.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IKullaniciService _kullaniciService;

        public KullaniciController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        [HttpPost("kullaniciekle")]
        public IActionResult KullaniciEkle(Kullanici kullanici)
        {
            var result = _kullaniciService.Add(kullanici);
            return Ok(result);
        }

    }
}
