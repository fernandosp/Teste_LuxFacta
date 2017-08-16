using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Luxfacta.Enquete.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luxfacta.Enquete.Application.ViewModels
{
    public class VoteViewModel
    {
        [Key]
        public int option_id { get; set; }
        public int qty { get; set; }
    }
}
