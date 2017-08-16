using Luxfacta.Enquete.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Luxfacta.Enquete.Infra.Data.EntityConfig
{
    public class PollConfig : EntityTypeConfiguration<Poll>
    {
        public PollConfig()
        {
            HasKey(p => p.poll_id);

            Property(p => p.poll_description).IsRequired();
            //Ignore(c => c.ValidationResult);
            ToTable("Poll");
        }
    }
}
