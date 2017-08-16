using System.ComponentModel.DataAnnotations.Schema;

namespace Luxfacta.Enquete.Domain.Entities
{
    public class Vote
    {       
        public int option_id { get; set; }

        public int poll_id { get; set; }
        public int qty { get; set; }
        //public virtual Stats stats { get; set; }
    }
}
