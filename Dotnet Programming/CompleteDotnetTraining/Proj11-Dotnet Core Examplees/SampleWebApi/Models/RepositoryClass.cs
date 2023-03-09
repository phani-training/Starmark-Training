using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleWebApi.Models
{
    public interface IDataRepo
    {
        List<Data> GetAll();
        Data Get(string id);
        void Add(Data data);
        void Update(Data data);
        void Delete(string id);
        
    }
    public class RepositoryClass : IDataRepo
    {
        private readonly DataDbContext _context = null;
        public RepositoryClass(DataDbContext context)
        {
            _context = context;
        }

        public void Add(Data data)
        {
            _context.Datas.Add(data);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var data = Get(id);
            _context.Datas.Remove(data);
            _context.SaveChanges();
        }

        public Data Get(string id)
        {
            var dataId = int.Parse(id);
            var data = _context.Datas.FirstOrDefault((d) => d.DataId == dataId);
            if (data == null) throw new Exception("Data not found");
            return data;
        }

        public List<Data> GetAll()
        {
            return _context.Datas.ToList();
        }

        public void Update(Data data)
        {
            var found = _context.Datas.FirstOrDefault((d) => d.DataId == data.DataId);
            if (found == null) throw new Exception("Data not found");
            found.DataName = data.DataName;
            found.DataDate = data.DataDate;
            _context.SaveChanges();
        }
    }
}
