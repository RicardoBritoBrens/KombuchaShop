using KombuchaShop.Models.Pocos;

namespace KombuchaShop.Models.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
