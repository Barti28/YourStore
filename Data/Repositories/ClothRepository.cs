using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourStore.Data.interfaces;
using YourStore.Data.Models;

namespace YourStore.Data.Repositories
{
    public class ClothRepository : IClothRepository
    {
        private readonly AppDbContext _appDbContext;
        public ClothRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Clothes> Clothes => _appDbContext.Clothes.Include(c => c.Category);

        public IEnumerable<Clothes> PreferredClothes => _appDbContext.Clothes.Where(p => p.IsPreferredCloth).Include(c => c.Category);

        public Clothes GetClothesById(int clothId) => _appDbContext.Clothes.FirstOrDefault(p => p.ClothesId == clothId);

    }
}
