using Luxfacta.Enquete.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Application.Interfaces
{
    public interface IEnqueteAppService : IDisposable
    {
        PollOptionsViewModel ObterEnquetePorId(int id);
        PollOptionsViewModel AdicionarPoll(PollOptionsViewModel Poll);
        PollOptionsViewModel ObterPollPorId(int id);

        OptionViewModel AdicionarOption(OptionViewModel Option);
        OptionViewModel ObterOptionPorId(int id);
        VoteViewModel AdicionarVoto(int id);

        StatsViewModel ObterStatisticas(int id);
        StatsViewModel AdicionarVisualizacao(int id);

    }
}
