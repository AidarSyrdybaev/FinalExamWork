using FinalExamWork.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Factories.Contracts
{
    public interface IApplicationDbContextFactory
    {
        ApplicationDbContext CreateContext();
    }
}
