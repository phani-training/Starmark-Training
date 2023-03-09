using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Models
{
    public class Data
    {
        [Column("DataId")]
        public int DataId { get; set; }
        public string DataName { get; set; }
        public DateTime DataDate { get; set; }
    }

    public class DataDbContext : DbContext
    {
        private readonly string _connectionstring = string.Empty;
        public DataDbContext(DbContextOptions<DataDbContext> optionsBuilder) :base(optionsBuilder)
        {
           
        }

        public DbSet<Data> Datas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
