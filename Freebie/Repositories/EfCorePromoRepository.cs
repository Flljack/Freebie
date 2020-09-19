using Freebie.Models;

namespace Freebie.Repositories
{
    public class EfCorePromoRepository : EfCoreRepository<Promo, ApplicationContext>
    {
        public EfCorePromoRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
    