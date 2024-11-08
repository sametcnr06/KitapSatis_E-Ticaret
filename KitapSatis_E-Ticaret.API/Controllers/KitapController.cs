using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KitapSatis_E_Ticaret.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        private readonly IKitapService _kitapService;

        public KitapController(IKitapService kitapService)
        {
            _kitapService = kitapService;
        }

        // Tüm kitapları listeleme
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var kitaplar = await _kitapService.GetAllAsync();
            return Ok(kitaplar);
        }

        // Belirli bir kitabı görüntüleme
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var kitap = await _kitapService.GetByIdAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }
            return Ok(kitap);
        }

        // Yeni kitap ekleme (Yalnızca admin)
        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Kitap kitap)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _kitapService.AddAsync(kitap);
            return CreatedAtAction(nameof(GetById), new { id = kitap.KitapID }, kitap);
        }

        // Kitap güncelleme (Yalnızca admin)
        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Kitap kitap)
        {
            if (id != kitap.KitapID)
            {
                return BadRequest();
            }
            await _kitapService.UpdateAsync(kitap);
            return NoContent();
        }

        // Kitap silme (Yalnızca admin)
        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _kitapService.DeleteAsync(id);
            return NoContent();
        }

        // Yalnızca yetkilendirilmiş kullanıcılar için tüm kitapları listeleme
        [Authorize]
        [HttpGet("authorized-books")]
        public async Task<IActionResult> GetAuthorizedBooks()
        {
            var books = await _kitapService.GetAllAsync();
            return Ok(books);
        }
    }
}