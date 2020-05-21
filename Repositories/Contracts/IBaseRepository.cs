using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Repositories.Contracts
{
    public interface IBaseRepository<baseClass> where baseClass : class
    {
        IEnumerable<baseClass> FindAll();
        baseClass FindByID(int parID);
        bool Create(baseClass locBaseClass);
        bool Update(baseClass locBaseClass);
        bool Delete(baseClass locBaseClass);
        bool Save();
    }
}
