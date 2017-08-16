using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Luxfacta.Enquete.Domain.Entities;

namespace Luxfacta.Enquete.Application.ViewModels
{
    public class StatsViewModel
    {
        public int views { get; set; }
        public virtual ICollection<VoteViewModel> votes { get; set; }
    }
}
