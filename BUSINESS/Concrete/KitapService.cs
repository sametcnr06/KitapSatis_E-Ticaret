using Business.Abstract;
using DATA.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KitapService : IKitapService
    {
        private readonly IRepository<Kitap> _kitapRepository;

        public KitapService(IRepository<Kitap> kitapRepository)
        {
            _kitapRepository = kitapRepository;
        }

        public async Task<IEnumerable<Kitap>> GetAllAsync()
        {
            return await _kitapRepository.GetAllAsync();
        }

        public async Task<Kitap> GetByIdAsync(int id)
        {
            return await _kitapRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Kitap kitap)
        {
            await _kitapRepository.AddAsync(kitap);
        }

        public async Task UpdateAsync(Kitap kitap)
        {
            await _kitapRepository.UpdateAsync(kitap);
        }

        public async Task DeleteAsync(int id)
        {
            await _kitapRepository.DeleteAsync(id);
        }
    }
}
