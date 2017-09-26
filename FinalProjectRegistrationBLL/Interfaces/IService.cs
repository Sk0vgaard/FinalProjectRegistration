using System.Collections;
using System.Collections.Generic;

namespace FinalProjectRegistrationBLL.Interfaces
{
    public interface IService<TEntity>
    {
        TEntity Create(TEntity entity);

        TEntity Get(int id);

        IList<TEntity> GetAll();
    }
}