using Luxfacta.Enquete.Domain.Entities;

namespace Luxfacta.Enquete.Domain.Interfaces.Repository
{
    public interface IPollRepository : IRepository<Poll>
    {
        Poll AdicionarPoll(Poll poll);
    }
}
