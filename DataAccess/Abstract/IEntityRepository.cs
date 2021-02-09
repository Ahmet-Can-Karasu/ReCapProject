﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntiti, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Func<T, bool> filter);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}