using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Luxfacta.Enquete.Domain.Entities;

namespace Luxfacta.Enquete.Application.ViewModels
{
    public class PollOptionsViewModel
    {
        [Key]
        public int poll_id { get; set; }
        public string poll_description { get; set; }
        public virtual ICollection<OptionViewModel> options { get; set; }

        //OPTION
        //[Key]
        //public int option_id { get; set; }
        //public string option_description { get; set; }
    
    }
}
