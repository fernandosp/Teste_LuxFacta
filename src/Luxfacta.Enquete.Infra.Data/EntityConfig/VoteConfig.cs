using Luxfacta.Enquete.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Luxfacta.Enquete.Infra.Data.EntityConfig
{
    public class VoteConfig : EntityTypeConfiguration<Vote>
    {
        public VoteConfig()
        {
            HasKey(p => new { p.poll_id, p.option_id } );
            ToTable("Vote");
        }
    }
}
