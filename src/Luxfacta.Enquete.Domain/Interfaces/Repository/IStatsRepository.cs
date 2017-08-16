using Luxfacta.Enquete.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Domain.Interfaces.Repository
{
    public interface IStatsRepository : IRepository<Stats>
    {
        Stats AdiconarVisualizacao(int id);

        Stats ObterEstatisticas(int id);
    }
}
