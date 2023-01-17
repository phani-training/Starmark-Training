using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace SampleDataAccessApp
{
    /*
     * Requirement: Insert a new Employee with Dept Details. if the Dept name exists, extract the id and insert into Employee Table, else create a new record in the DeptTable for the new DeptName, and extract the newly created DeptID and add the Employee.
     * InsertEmployee StoredProc should be there. 
     * A Function to Extract the DeptID based on DeptName.
     * A statement to insert the DeptName into the DeptTable. 
     */
    class TransactionDemo
    {
        static readonly string strConnection = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

        private static void addEmployee(string name, string address, int salary, string deptName)
        {
            SqlTransaction transaction = null;
            SqlConnection con = new SqlConnection(strConnection);
            string cmdGetDeptId = $"Select dbo.GetDept('{deptName}') as DeptId";
            string cmdInsertDept = "InsertDept";
            int depId = 0;
            try
            {
                con.Open();
                transaction = con.BeginTransaction();
                //First operation: Get the DeptId from DeptName
                SqlCommand cmd1 = new SqlCommand(cmdGetDeptId, con, transaction);
                depId = (int)cmd1.ExecuteScalar();
                if(depId == 0)
                {
                    //2nd Operation: Inserting the DeptName
                    SqlCommand cmd2 = new SqlCommand(cmdInsertDept, con, transaction);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@deptName", deptName);
                    cmd2.Parameters.AddWithValue("@deptId", 0);
                    cmd2.Parameters[1].Direction = ParameterDirection.Output;
                    cmd2.ExecuteNonQuery();
                    depId = (int)cmd2.Parameters[1].Value;
                }
                //3rd Operation: Insert to Employee Table
                SqlCommand cmd3 = new SqlCommand("INSERTEMPLOYEE", con, transaction);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@empName", name);
                cmd3.Parameters.AddWithValue("@empAddress", null);
                cmd3.Parameters.AddWithValue("@empSalary", salary);
                cmd3.Parameters.AddWithValue("@deptId", depId);
                cmd3.Parameters.AddWithValue("@empId", 0);
                cmd3.Parameters[4].Direction = ParameterDirection.Output;
                cmd3.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("The Employee has been added to the database with an ID generated as " + cmd3.Parameters[4].Value);
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
        }
        static void Main(string[] args)
        {
            addEmployee("Ramesh", "Chennai", 56000, "PreSales");
        }
    }
}