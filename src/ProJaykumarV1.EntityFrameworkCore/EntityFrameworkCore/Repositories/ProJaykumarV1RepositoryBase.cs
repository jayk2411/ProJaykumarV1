﻿using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace ProJaykumarV1.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class ProJaykumarV1RepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<ProJaykumarV1DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProJaykumarV1RepositoryBase(IDbContextProvider<ProJaykumarV1DbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="ProJaykumarV1RepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class ProJaykumarV1RepositoryBase<TEntity> : ProJaykumarV1RepositoryBase<TEntity, int>, IRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        protected ProJaykumarV1RepositoryBase(IDbContextProvider<ProJaykumarV1DbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
