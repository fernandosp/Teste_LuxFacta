using Luxfacta.Enquete.Domain.Entities;
using Luxfacta.Enquete.Domain.Interfaces.Repository;
using Luxfacta.Enquete.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Luxfacta.Enquete.Domain.Services
{
    public class EnqueteService : IEnqueteService
    {
        private readonly IPollRepository _pollRepository;
        private readonly IOptionRepository _optionRepository;
        private readonly IVoteRepository _voteRepository;
        private readonly IStatsRepository _statsRepository;

        public EnqueteService(IPollRepository pollRepository, IOptionRepository optionRepository, IVoteRepository voteRepositoy, IStatsRepository statsRepository)
        {
            _pollRepository = pollRepository;
            _optionRepository = optionRepository;
            _voteRepository = voteRepositoy;
            _statsRepository = statsRepository;
        }

        public Poll AdicionarPoll(Poll poll)
        {
            return _pollRepository.AdicionarPoll(poll);
        }

        public Poll ObterPollPorId(int id)
        {
            return _pollRepository.ObterPorId(id);
        }

        public Option AdicionarOption(Option option)
        {
            return _optionRepository.Adicionar(option);
        }

        public Option ObterOptionPorId(int id)
        {
            return _optionRepository.ObterPorId(id);
        }

        public Vote AdicionarVoto(int id)
        {
            var option = ObterOptionPorId(id);
            return _voteRepository.AdicionarVoto(option);
        }

        public Stats ObterStatisticas(int id)
        {
            return _statsRepository.ObterEstatisticas(id);
        }


        public Stats AdicionarVisualizacao(int id)
        {
           return _statsRepository.AdiconarVisualizacao(id);
        }

        public void Dispose()
        {
            _pollRepository.Dispose();
            GC.SuppressFinalize(this);
        }


    }
}
