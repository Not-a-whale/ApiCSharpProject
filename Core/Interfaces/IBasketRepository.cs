using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
        public Task<CustomerBasket> GetBasketAsync(string basketId);
        public Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket);
        public Task<bool> DeleteBasketAsync(string basketId);
    }
}
