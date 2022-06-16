using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeView.Models;

namespace TreeView.Repositories
{
    
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _context;
        public DataRepository(DataContext context)
        {
            _context = context;
        }
        public DataModel Get(int dataId)
            => _context.Datas.SingleOrDefault(x => x.DataId.Equals(dataId));

        public IQueryable<DataModel> GetAll()
            => _context.Datas;

        public void Add(DataModel data)
        {
            _context.Datas.Add(data);
            _context.SaveChanges();
        }

        public void Delete(int dataId)
        {
            var result = _context.Datas.SingleOrDefault(x => x.DataId.Equals(dataId));
            if (result != null)
            {
                _context.Remove(result);
                _context.SaveChanges();
            }
        }

        public void Update(int dataId, DataModel data)
        {
            var result = _context.Datas.SingleOrDefault(x => x.DataId.Equals(dataId));
            if(result != null)
            {
                result.DataName = data.DataName;
                result.ParentId = data.ParentId;
                _context.SaveChanges();
            }
        }
    }
}
