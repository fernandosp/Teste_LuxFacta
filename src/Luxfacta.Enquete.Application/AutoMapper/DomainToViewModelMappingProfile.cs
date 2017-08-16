using AutoMapper;
using Luxfacta.Enquete.Application.ViewModels;
using Luxfacta.Enquete.Domain.Entities;


namespace Luxfacta.Enquete.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Poll, EnqueteViewModel>();
            CreateMap<Vote, EnqueteViewModel>();
            CreateMap<Stats, EnqueteViewModel>();
            CreateMap<Option, EnqueteViewModel>();

            CreateMap<Poll, PollOptionsViewModel>();
            CreateMap<Option, PollOptionsViewModel>();
            CreateMap<Vote, VoteViewModel>();
            CreateMap<Stats, StatsViewModel>();
            CreateMap<Option, OptionViewModel>();
        }
    }
}
