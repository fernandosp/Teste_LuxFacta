using Luxfacta.Enquete.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Infra.Data.EntityConfig
{
    public class OptionConfig : EntityTypeConfiguration<Option>
    {
        public OptionConfig()
        {
            HasKey(o=>o.option_id);
            Property(o => o.option_description).IsRequired();
            //Ignore(o => o.ValidationResult);

            ToTable("Options");

        }
    }
}
