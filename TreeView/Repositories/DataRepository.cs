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
        //Metoda do pobrania elementu o konkretnym Id
        public DataModel Get(int dataId)
            => _context.Datas.SingleOrDefault(x => x.DataId.Equals(dataId));

        //Metoda do pobrania wszystkich elementów
        public IQueryable<DataModel> GetAll()
            => _context.Datas;

        //Metoda do dodania elementu
        public void Add(DataModel data)
        {
            _context.Datas.Add(data);
            _context.SaveChanges();
        }

        //Metoda do usunięcia elementu
        public void Delete(int dataId)
        {
            var result = _context.Datas.SingleOrDefault(x => x.DataId.Equals(dataId));
            if (result != null)
            {
                _context.Remove(result);
                _context.SaveChanges();
            }
        }

        //Metoda do edycji elementu
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

        // Wypełnij danymi testowymi
        public void FakeData() 
        {
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    DataModel element = new DataModel()
            //    {
            //        DataId = i,
            //        DataName = "Name",
            //        ParentId = rnd.Next(5)
            //    };
            //    _context.Datas.Add(element);
            //}
        }

    }
}
