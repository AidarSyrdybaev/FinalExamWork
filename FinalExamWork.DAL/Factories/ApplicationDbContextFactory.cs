using FinalExamWork.DAL.Context;
using FinalExamWork.DAL.Factories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Factories
{
    public class ApplicationDbContextFactory : IApplicationDbContextFactory
    {
        private DbContextOptions _options;

        public ApplicationDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public ApplicationDbContext CreateContext()
        {
            return new ApplicationDbContext(_options);
        }
    }
}
