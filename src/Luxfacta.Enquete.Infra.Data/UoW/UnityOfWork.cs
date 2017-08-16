using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luxfacta.Enquete.Infra.Data.Context;
using Luxfacta.Enquete.Infra.Data.Interfaces;

namespace Luxfacta.Enquete.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EnqueteContext _context;
        private bool _disposed;

        public UnitOfWork(EnqueteContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
