using Luxfacta.Enquete.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Luxfacta.Enquete.Application.ViewModels
{
    public class EnqueteViewModel
    {
        //Poll
        [Key]
        public int poll_id { get; set; }
        public string poll_description { get; set; }
        public virtual ICollection<Option> options { get; set; }

        //Option
        [Key]
        public int option_id { get; set; }
        public string option_description { get; set; }
        public virtual Poll pool { get; set; }

        //Stats
        public int views { get; set; }
        public virtual ICollection<Vote> votes { get; set; }

        //Vote
        public int qty { get; set; }
        public virtual Stats stats { get; set; }




    }
}
