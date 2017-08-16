using Luxfacta.Enquete.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Luxfacta.Enquete.Application.ViewModels
{
    public class OptionViewModel
    {
        [Key]
        public int option_id { get; set; }
        public string option_description { get; set; }
    }
}
