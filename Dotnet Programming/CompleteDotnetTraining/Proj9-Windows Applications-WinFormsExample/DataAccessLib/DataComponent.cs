using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public interface IDataComponent
    {
        void RegisterNewEmployee(string name, string address, int salary, long phoneNo);
        Task<DataTable> GetAllEmployees();
        void UpdateEmployee(int id, string name, string address, int salary, long phoneNo);
        DataTable FindEmployee(int id);
    }

    class DataComponent : IDataComponent
    {
        private readonly string _connectionString = string.Empty;

        public DataComponent()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        }

        public DataTable FindEmployee(int id)
        {
            string strGetAll = $"SELECT * FROM EMPTABLE WHERE EMPID = {id}";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(strGetAll, con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    throw new Exception("Matching Employee not found");
                }
                var table = new DataTable("Employees");
                table.Load(reader);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public async Task<DataTable> GetAllEmployees()
        {
            string strGetAll = "SELECT * FROM EMPTABLE";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(strGetAll, con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                var table = new DataTable("Employees");
                table.Load(reader);
                return await Task.Run(()=> table);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public void RegisterNewEmployee(string name, string address, int salary, long phoneNo)
        {
            string strInsert = $"Insert into EmpTable values('{name}','{address}', {salary}, {phoneNo})";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(strInsert, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public void UpdateEmployee(int id, string name, string address, int salary, long phoneNo)
        {
            string strUpdate = $"Update EmpTable Set EmpName = '{name}', EmpAddress = '{address}', EmpSalary =  {salary}, EmpPhone = {phoneNo} where EmpId = {id})";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(strUpdate, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }

    public static class DataFactory
    {
        public static IDataComponent GetComponent() => new DataComponent();
    }
}
