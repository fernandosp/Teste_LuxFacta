using Luxfacta.Enquete.Domain.Entities;
using Luxfacta.Enquete.Domain.Interfaces.Repository;
using Luxfacta.Enquete.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.Entity;

namespace Luxfacta.Enquete.Infra.Data.Repository
{
    public class PollRepository : Repository<Poll> , IPollRepository
    {
        public PollRepository(EnqueteContext context) : base(context)
        {
        }

        public override Poll ObterPorId(int id)
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT p.poll_id " +
                       ",p.poll_description " +
                       ",o.option_id " +
                       ",o.option_description " +
                       "FROM Poll p " +
                       "LEFT JOIN Options o " +
                       "ON p.poll_id  = o.pool_poll_id " +
                       "WHERE p.poll_id = @sid " +
                       "ORDER BY o.option_id ";

            var poll = new List<Poll>();
            cn.Query<Poll, Option, Poll>(sql,
                (p, o) =>
                {
                    poll.Add(p);
                    if (o != null)
                        poll[0].options.Add(o);
                    return poll.FirstOrDefault();
                }, new { sid = id }, splitOn: "poll_id, option_id");
            
            return poll.FirstOrDefault();
        }

        public Poll AdicionarPoll(Poll poll)
        {
            var objReturn = DbSet.Add(poll);
            SaveChanges();
            return objReturn;
        }
    }
}
