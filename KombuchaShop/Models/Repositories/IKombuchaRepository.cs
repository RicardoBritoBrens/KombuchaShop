using System.Collections.Generic;

namespace KombuchaShop.Models.Repositories
{
    public interface IKombuchaRepository
    {
        IEnumerable<Kombucha> AllKombuchas { get; }

        Kombucha GetKombuchaById(int kombuchaId);
    }
}