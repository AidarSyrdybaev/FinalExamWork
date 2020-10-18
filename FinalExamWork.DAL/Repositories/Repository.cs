using FinalExamWork.DAL.Context;
using FinalExamWork.DAL.Entites;
using FinalExamWork.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamWork.DAL.Repositories
{
    public class Repository<Entity> : IRepository<Entity> where Entity : class, IEntity
    {
        private ApplicationDbContext _applicationDbContext;
        protected DbSet<Entity> _Entities { get; set; }

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Update(Entity entity)
        {
            _Entities.Update(entity);
            _applicationDbContext.SaveChanges();
        }

        public Entity Create(Entity entity)
        {
            var Entry = _Entities.Add(entity);
            _applicationDbContext.SaveChanges();
            return Entry.Entity;

        }

        public void Delete(int Id)
        {
            var DeleteEntity = _Entities.FirstOrDefault(i => i.Id == Id);
            _Entities.Remove(DeleteEntity);
        }

        public Entity GetById(int Id)
        {
            var Entity = _Entities.FirstOrDefault(i => i.Id == Id);
            return Entity;
        }

        public List<Entity> GetAll()
        {
            return _Entities.ToList();
        }

    }
}
