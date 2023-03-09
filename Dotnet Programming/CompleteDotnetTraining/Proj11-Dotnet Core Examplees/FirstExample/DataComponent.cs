using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tblData")]
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
    public DataDbContext(string connection)
    {
        _connectionstring = connection;
    }

    public DbSet<Data> Datas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(_connectionstring);
    }
}

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataDbContext>
{
    public DataDbContext CreateDbContext(string[] args)
    {
        var connectionString = "Data Source = 192.168.171.36;Initial Catalog = Phaniraj-CSMM40;Integrated Security=True;TrustServerCertificate = True";
        
        return new DataDbContext(connectionString);
    }
}