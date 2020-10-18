using FinalExamWork.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Repositories.Contracts
{
    public interface IRepository<Entity> where Entity : class, IEntity
    {
        void Update(Entity entity);

        Entity Create(Entity entity);

        public void Delete(int Id);

        public Entity GetById(int Id);

        public List<Entity> GetAll();
    }
}
