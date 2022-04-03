using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KombuchaShop.Models.Repositories
{
    public class KombuchaRepository : IKombuchaRepository
    {
        private readonly AppDbContext _context;

        public KombuchaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Kombucha> AllKombuchas => _context.Kombuchas.Include(x => x.Category).ToList();

        public Kombucha GetKombuchaById(int kombuchaId)
        {
            return _context.Kombuchas.FirstOrDefault(x => x.KombuchaId == kombuchaId);
        }
    }
}