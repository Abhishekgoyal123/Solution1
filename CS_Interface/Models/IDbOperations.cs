using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.Models
{
    public interface IDbOperations<TEntity, in TPk> where TEntity : Staff
    {
        Dictionary<int, Staff> GetAll();
        //Dictionary<int, Staff> Get(TPk id);
        void Create(int id, TEntity entity);
        Dictionary<int, Staff> Update(TPk id, TEntity entity);
        Dictionary<int, Staff> Delete(TPk id);
    }
}
