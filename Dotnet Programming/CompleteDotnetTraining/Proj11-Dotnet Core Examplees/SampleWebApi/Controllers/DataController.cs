using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataRepo _repo;

        public DataController(IDataRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public List<Data> GetAllRecords() => _repo.GetAll();
        [HttpGet]
        [Route("{id}")]
        public Data GetRecord(string id) => _repo.Get(id);
        [HttpPost]
        public void AddNew(Data data) => _repo.Add(data);

        [HttpPut]
        public void Modify(Data data) => _repo.Update(data);

        [HttpDelete]
        public void Delete(string id) => _repo.Delete(id);
    }
}