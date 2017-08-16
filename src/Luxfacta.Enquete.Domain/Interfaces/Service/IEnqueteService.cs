using Luxfacta.Enquete.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Domain.Interfaces.Services
{
    public interface IEnqueteService : IDisposable
    {
        Poll AdicionarPoll(Poll Poll);
        Poll ObterPollPorId(int id);
        
        Option AdicionarOption(Option Option);
        Option ObterOptionPorId(int id);

        Vote AdicionarVoto(int id);

        Stats ObterStatisticas(int id);
        Stats AdicionarVisualizacao(int id);
      
    }
}
