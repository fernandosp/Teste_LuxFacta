using Luxfacta.Enquete.Domain.Entities;
using System.Linq;
using DomainValidation.Interfaces.Specification;

namespace Luxfacta.Enquete.Domain.Specifications
{
    public class EnqueteDeveTerOpcoesSpecifications : ISpecification<Poll>
    {
         public bool IsSatisfiedBy(Poll poll)
        {
            return poll.options != null && poll.options.Any();
        }
    }
}
