using FinalExamWork.DAL.Repositories;
using FinalExamWork.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed;
        public IShopRepository Shops { get; }
        public ICommentRepository Comments { get; }
        public IImageRepository Images { get; }
        

        public UnitOfWork(ApplicationDbContext context)
        {
            Shops = new ShopRepository(context);
            Comments = new CommentRepository(context);
            Images = new ImageRepository(context);
            _context = context;
        }


        #region Disposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                _context.Dispose();

            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
