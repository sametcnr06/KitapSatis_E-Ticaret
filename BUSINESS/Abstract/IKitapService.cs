using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKitapService
    {
        Task<IEnumerable<Kitap>> GetAllAsync();
        Task<Kitap> GetByIdAsync(int id);
        Task AddAsync(Kitap kitap);
        Task UpdateAsync(Kitap kitap);
        Task DeleteAsync(int id);
    }
}
