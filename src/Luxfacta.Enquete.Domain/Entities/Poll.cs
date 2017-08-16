using System.Collections.Generic;

namespace Luxfacta.Enquete.Domain.Entities
{
    public class Poll
    {
        public Poll()
        {
            options = new List<Option>();
        }

        public int poll_id { get; set; }
        public string poll_description { get; set; }
        public virtual List<Option> options { get; set; }
    }
}
