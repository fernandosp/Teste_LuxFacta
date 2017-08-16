using AutoMapper;
using Luxfacta.Enquete.Application.ViewModels;
using Luxfacta.Enquete.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<EnqueteViewModel, Poll>();
            CreateMap<EnqueteViewModel, Vote>();
            CreateMap<EnqueteViewModel, Stats>();
            CreateMap<EnqueteViewModel, Option>();

            CreateMap<PollOptionsViewModel, Poll>();
            CreateMap<PollOptionsViewModel, Option>();
            CreateMap<VoteViewModel, Vote>();
            CreateMap<StatsViewModel, Stats>();
            CreateMap<OptionViewModel, Option>();
        }
    }
}
