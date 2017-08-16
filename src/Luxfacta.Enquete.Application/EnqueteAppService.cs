using AutoMapper;
using Luxfacta.Enquete.Application.Interfaces;
using Luxfacta.Enquete.Application.ViewModels;
using Luxfacta.Enquete.Domain.Entities;
using Luxfacta.Enquete.Domain.Interfaces.Services;
using Luxfacta.Enquete.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Application
{
    public class EnqueteAppService : ApplicationService, IEnqueteAppService
    {
        private readonly IEnqueteService _enqueteService;
        public EnqueteAppService(IEnqueteService enqueteService, IUnitOfWork uow)
            : base(uow)
        {
            _enqueteService = enqueteService;
        }

        public PollOptionsViewModel ObterEnquetePorId(int id)
        {
            return Mapper.Map<Poll, PollOptionsViewModel>(_enqueteService.ObterPollPorId(id));
        }

        public StatsViewModel ObterStats(int id)
        {
            return Mapper.Map<Stats, StatsViewModel>(_enqueteService.ObterStatisticas(id));
        }

        public PollOptionsViewModel AdicionarPoll(PollOptionsViewModel pollViewModel)
        {
            var poll = Mapper.Map<PollOptionsViewModel, Poll>(pollViewModel);
            var option = Mapper.Map<PollOptionsViewModel, Option>(pollViewModel);
            poll.options.Add(option);
            poll.options.RemoveAll(o => o.option_description == null);
            BeginTransaction();

            var pollReturn = _enqueteService.AdicionarPoll(poll);
            pollViewModel = Mapper.Map<Poll, PollOptionsViewModel>(pollReturn);

            Commit();

            return pollViewModel;

        }

        public PollOptionsViewModel ObterPollPorId(int id)
        {
            return Mapper.Map<Poll, PollOptionsViewModel>(_enqueteService.ObterPollPorId(id));
        }

        public OptionViewModel AdicionarOption(OptionViewModel Option)
        {
            throw new NotImplementedException();
        }

        public OptionViewModel ObterOptionPorId(int id)
        {
            return Mapper.Map<Option, OptionViewModel>(_enqueteService.ObterOptionPorId(id));
        }

        public VoteViewModel AdicionarVoto(int id)
        {
           return Mapper.Map<Vote,VoteViewModel>( _enqueteService.AdicionarVoto(id));
        }

        public StatsViewModel ObterStatisticas(int id)
        {
            return Mapper.Map<Stats, StatsViewModel>(_enqueteService.ObterStatisticas(id));
        }

        public StatsViewModel AdicionarVisualizacao(int id)
        {
            return Mapper.Map<Stats, StatsViewModel>(_enqueteService.AdicionarVisualizacao(id));
        }

        public void Dispose()
        {
            _enqueteService.Dispose();
            GC.SuppressFinalize(this);
        }

       
    }
}
