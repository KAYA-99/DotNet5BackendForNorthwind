﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// core katmanı diğer katmanları referans almaz, alırsa northwinde bağımmlı olursun ranacar da kullanamazsın. core katmanı evrenseldir
namespace Core.DataAccess
{
    // generic constraint - generic kısıt
    // class : referans tip
    // IEntity : IEntity olabilir ya da IEntity implement eden bir nesne olabilir
    // new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
