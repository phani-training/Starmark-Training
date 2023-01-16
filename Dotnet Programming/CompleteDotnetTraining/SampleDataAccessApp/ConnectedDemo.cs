using System;
using System.Data;
using System.Data.SqlClient;

//Connect to the database
//Execute a Command to the database to extract the data for our application. 
//Read the data and display it on the Console UI. 

namespace SampleDataAccessApp
{
    static class Database
    {
        const string STRCONNECTION = "Data Source=192.168.171.36;Initial Catalog=Phaniraj-CSMM40;Integrated Security=True";

        const string STRQUERY = "SELECT * FROM tblEmployee";
        public static DataTable GetAllRecords()
        {
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(STRQUERY, con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable("EmpRecords");
                table.Load(reader);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }

   
    class ConnectedDemo
    {
        const string STRCONNECTION = "Data Source=192.168.171.36;Initial Catalog=Phaniraj-CSMM40;Integrated Security=True";

        const string STRQUERY = "SELECT * FROM tblEmployee";
        const string STRFIND = "SELECT * FROM tblEmployee WHERE EmpName = @name";
        const string STRINSERT = "INSERT INTO tblEmployee VALUES(@name, @address, @salary, @deptId)";
        const string STRINSERTPROC = "InsertEmployee";

        static void Main(string[] args)
        {
            //readingdata();
            //displayAsTable();
            //displayDetails("Ivory");
            //displayDetailsUsingParameters("Shivaram");
            //addNewRecord("Phaniraj", "Bangalore", 56000, 4);
            //addNewRecordFromInputs();
            addNewRecordUsingStoredProc("David Johnson","Chicago", 50000, 7);
            displayAsTable();
        }

        private static void addNewRecordUsingStoredProc(string name, string address, int salary, int deptId)
        {
            int empId = 0;
            SqlConnection sqlCon = new SqlConnection(STRCONNECTION);
            SqlCommand sqlCmd = new SqlCommand(STRINSERTPROC, sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@empName", name);
            sqlCmd.Parameters.AddWithValue("@empAddress", address);
            sqlCmd.Parameters.AddWithValue("@empSalary", salary);
            sqlCmd.Parameters.AddWithValue("@deptId", deptId);
            sqlCmd.Parameters.AddWithValue("@empId", empId);
            sqlCmd.Parameters[4].Direction = ParameterDirection.Output;
            try
            {
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                empId = Convert.ToInt32(sqlCmd.Parameters[4].Value);
                Console.WriteLine("The EmpID of the newly added Employee is " + empId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

        }

        private static void addNewRecordFromInputs()
        {
            string name = Utilities.Prompt("Enter the Name");
            string address = Utilities.Prompt("Enter the Address");
            int salary = Utilities.GetNumber("Enter the Salary");
            int deptId = getDepartment();
            addNewRecord(name, address, salary, deptId);
        }

        private static int getDepartment()
        {
            string query = "SELECT * FROM tblDept";
            SqlConnection sqlCon = new SqlConnection(STRCONNECTION);
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();
            var reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"DeptName: {reader[1]}, DeptId: {reader[0]}");
            }
            sqlCon.Close();
            int no = Utilities.GetNumber("Enter the DeptId from the list above");
            return no;
        }

        private static void addNewRecord(string name, string address, int salary, int deptId)
        {
            SqlConnection sqlCon = new SqlConnection(STRCONNECTION);
            SqlCommand sqlCmd = new SqlCommand(STRINSERT, sqlCon);
            sqlCmd.Parameters.AddWithValue("@name", name);
            sqlCmd.Parameters.AddWithValue("@address", address);
            sqlCmd.Parameters.AddWithValue("@salary", salary);
            sqlCmd.Parameters.AddWithValue("@deptId", deptId);

            try
            {
                sqlCon.Open();
                var rowsAffected = sqlCmd.ExecuteNonQuery();
                if(rowsAffected != 1)
                {
                    throw new Exception("Failed to add the record to the database");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private static void displayDetailsUsingParameters(string name)
        {
            SqlCommand cmd = new SqlCommand(STRFIND, new SqlConnection(STRCONNECTION));
            
            try
            {
                cmd.Parameters.AddWithValue("@name", name);//name of the parameter
                cmd.Connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmpName: {reader[1]}\nEmpAddress: {reader[2]}\nEmpSalary:{reader[3]:c}\n");
                }

            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        private static void displayDetails(string name)
        {
            string query = $"Select * from tblEMployee where EmpName like '%{name}%'";
            SqlConnection con = new SqlConnection(STRCONNECTION);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmpName: {reader[1]}\nEmpAddress: {reader[2]}\nEmpSalary:{reader[3]:c}\n");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void displayAsTable()
        {
            try
            {
                var table = Database.GetAllRecords();
                foreach(DataRow row in table.Rows)
                {
                    Console.WriteLine($"EmpName: {row[1]}\nEmpAddress: {row[2]}\nEmpSalary:{row[3]:c}\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void readingdata()
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = STRCONNECTION;

            SqlCommand sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = STRQUERY;

            try
            {
                sqlCon.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["EmpName"]} from {reader[2]}");//EmpName is the name of the Column
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
