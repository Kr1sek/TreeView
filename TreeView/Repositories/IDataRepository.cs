using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeView.Models;

namespace TreeView.Repositories
{
    public interface IDataRepository
    {
        DataModel Get(int dataId);
        IQueryable<DataModel> GetAll();
        void Add(DataModel data);
        void Update(int dataId, DataModel data);
        void Delete(int dataId);
    }
}
