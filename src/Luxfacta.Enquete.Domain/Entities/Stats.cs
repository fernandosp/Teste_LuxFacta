using System.Collections.Generic;

namespace Luxfacta.Enquete.Domain.Entities
{
    public class Stats
    {
        public Stats()
        {
            votes = new List<Vote>();
        }
        public int stats_id { get; set; }
        public int poll_id { get; set; }
        public int views { get; set; }
        public virtual ICollection<Vote> votes { get; set; }
    }
}
