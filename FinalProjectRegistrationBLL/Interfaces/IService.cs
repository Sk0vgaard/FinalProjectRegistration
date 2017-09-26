using System.Collections;
using System.Collections.Generic;

namespace FinalProjectRegistrationBLL.Interfaces
{
    public interface IService<TEntity>
    {
        TEntity Create(TEntity proposal);

        TEntity Get(int id);

        IList<TEntity> GetAll();
    }
}