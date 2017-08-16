using Luxfacta.Enquete.Domain.Entities;
using Luxfacta.Enquete.Domain.Interfaces.Repository;
using Luxfacta.Enquete.Infra.Data.Context;

namespace Luxfacta.Enquete.Infra.Data.Repository
{
    public class OptionRepository : Repository<Option>, IOptionRepository
    {
        public OptionRepository(EnqueteContext context)
            : base(context)
        {

        }
    }
}
