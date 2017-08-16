using Luxfacta.Enquete.Domain.Entities;
using Luxfacta.Enquete.Domain.Interfaces.Repository;
using Luxfacta.Enquete.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.Entity;


namespace Luxfacta.Enquete.Infra.Data.Repository
{
    public class VoteRepository : Repository<Vote>, IVoteRepository
    {
        public VoteRepository(EnqueteContext context)
            : base(context)
        {

        }
        public override Vote ObterPorId(int id)
        {
            return DbSet.Where(s => s.option_id == id).FirstOrDefault();
        }

        public Vote AdicionarVoto(Option option)
        {
            Vote vote = null;

            if (option == null)
                return vote;

            var objReturn = this.ObterPorId(option.option_id);
                        
                if (objReturn == null)
                {
                    objReturn = new Vote();
                    objReturn.option_id = option.option_id;
                    objReturn.poll_id = option.pool.poll_id;
                    objReturn.qty = 1;
                    Adicionar(objReturn);
                   
                }
                else {
                    objReturn.qty ++ ; //= objReturn.qty + 1;
                    Atualizar(objReturn);
                }
              
                Db.SaveChanges();
                return objReturn;
        }
    }
}
