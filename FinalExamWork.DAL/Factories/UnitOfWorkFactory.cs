using FinalExamWork.DAL.Context;
using FinalExamWork.DAL.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Factories
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private IApplicationDbContextFactory ApplicationDbContextFactory;

        public UnitOfWorkFactory(IApplicationDbContextFactory applicationDbFactory)
        {
            ApplicationDbContextFactory = applicationDbFactory;
        }

        public UnitOfWork CreateUnitOfWork()
        {
            return new UnitOfWork(ApplicationDbContextFactory.CreateContext());
        }
    }
}
