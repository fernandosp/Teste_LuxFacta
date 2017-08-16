using Luxfacta.Enquete.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Infra.Data.EntityConfig
{
    public class StatsConfig : EntityTypeConfiguration<Stats>
    {
        public StatsConfig()
        {
            HasKey(p => p.stats_id);
            ToTable("Stats");
        }
    }
}
