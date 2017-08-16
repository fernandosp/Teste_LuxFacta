using Luxfacta.Enquete.Domain.Entities;
using Luxfacta.Enquete.Domain.Interfaces.Repository;
using Luxfacta.Enquete.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.Entity;

namespace Luxfacta.Enquete.Infra.Data.Repository
{
    public class StatsRepository : Repository<Stats>, IStatsRepository
    {
        public StatsRepository(EnqueteContext context)
            : base(context)
        {

        }

        public Stats AdiconarVisualizacao(int id)
        {
            var objReturn = this.ObterPorId(id);
                        
            if (objReturn == null)
            {
                var stats = new Stats();
                stats.poll_id = id;
                stats.views = 1;
                DbSet.Add(stats);
                Db.SaveChanges();
                return stats;
            }
            else
            {
                objReturn.views = objReturn.views + 1;
                var entry = Db.Entry(objReturn);
                DbSet.Attach(objReturn);
                entry.State = EntityState.Modified;
                Db.SaveChanges();
                return objReturn;
            }
        }

        public override Stats ObterPorId(int id)
        {
            return DbSet.Where(s => s.poll_id == id).FirstOrDefault() ;
        }

        public Stats ObterEstatisticas(int id)
        {
            //if (this.AdiconarVisualizacao(id) != null) 
            //{
                var cn = Db.Database.Connection;
                var sql = @"SELECT " +
                            "S.VIEWS " +
                            ", V.OPTION_ID " +
                            ", V.QTY " +
                            "FROM STATS S " +
                            "LEFT JOIN VOTE V " +
                            "ON S.POLL_ID = V.POLL_ID " +
                            "WHERE S.POLL_ID =  @sid " +
                            "order by OPTION_ID";

                var stats = new List<Stats>();
                cn.Query<Stats, Vote, Stats>(sql,
                    (s, v) =>
                    {
                        stats.Add(s);
                        if (v != null)
                            stats[0].votes.Add(v);
                        return stats.FirstOrDefault();
                    }, new { sid = id }, splitOn: "poll_id, option_id");

                return stats.FirstOrDefault();
            //}
            //else
            //{
            //    return null;
            //}
        }
    }
}
