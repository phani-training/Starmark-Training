using System;

namespace FirstExample
{
    class Program
    {
        static void Main(string[] args)
        { //
            var connectionString = "Data Source=192.168.171.36;Initial Catalog=Phaniraj-CSMM40;Integrated Security=True;TrustServerCertificate=True";
            var context = new DataDbContext(connectionString);
            context.Datas.Add(new Data
            {
                DataDate = DateTime.Now.AddDays(-33),
                DataName = "Testing 2nd Time"
            });
            context.SaveChanges();
        }
    }
}
